using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AxMSTSCLib;
using Dapper;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MSTSCLib;
using Newtonsoft.Json;
using RemoteDesktopManagement.Control;
using RemoteDesktopManagement.Model;

namespace RemoteDesktopManagement
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            //Set theme
            StyleManager = metroStyleManager;
            var style = (MetroColorStyle)Db.Connection.QueryFirstOrDefault<int>("SELECT FValue FROM MyConfig WHERE FKey='Style'");
            metroStyleManager.Style = style;

            //Get global default settings
            var globalConfig = Db.Connection.QueryFirstOrDefault<string>("SELECT FValueStr FROM MyConfig WHERE FKey='GlobalConfig'");
            GlobalConfig.Instance = JsonConvert.DeserializeObject<GlobalConfig>(globalConfig) ?? new GlobalConfig();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Load remote desktop configuration asynchronously
            BeginInvoke(new Action(LoadHosts));
        }

        /// <summary>
        /// Load all remote desktop configurations
        /// </summary>
        private void LoadHosts()
        {
            panelBody.Visible = false;
            panelBody.Controls.Clear(); //Clear the original

            var hosts = (List<RemoteHost>)Db.Connection.Query<RemoteHost>(
                "SELECT Id,Name,Address,Port,Username,Pwd,Sort,ParentId,RemoteProgram,ExtJson FROM RemoteHost");

            //create group
            foreach (var hostGroup in hosts.Where(x => x.ParentId == 0).OrderByDescending(x => x.Sort))
            {
                //create group
                var hostGroupBox = new HostGroupBox { Dock = DockStyle.Top, Height = 100, Text = hostGroup.Name, ContextMenuStrip = menuGroup, Tag = hostGroup };
                hostGroupBox.GropNameMouseDown += (sender, e) =>
                {
                    if (e.Button == MouseButtons.Right)
                        _currSelectGroup = sender;
                };

                panelBody.Controls.Add(hostGroupBox);

                //Populate group content
                foreach (var host in hosts.Where(x => x.ParentId == hostGroup.Id).OrderBy(x => x.Sort))
                {
                    var title = new MetroTile
                    {
                        Name = "title",
                        ActiveControl = null,
                        Height = 60,
                        Text = $"{host.Name}\r\n  {host.FullAddress}",
                        UseSelectable = true,
                        UseVisualStyleBackColor = true,
                        Tag = host,
                        AutoSize = true,
                        ContextMenuStrip = menuHost,
                        StyleManager = metroStyleManager
                    };
                    title.Click += ConnectRemoteHost;
                    title.MouseDown += MenuTitleRightClick;
                    hostGroupBox.AddControl(title);
                }
            }
            panelBody.Visible = true;
        }

        /// <summary>
        /// Connect to remote desktop
        /// </summary>
        private void ConnectRemoteHost(object sender, EventArgs e)
        {
            var host = (RemoteHost)((MetroTile)sender).Tag;

            #region 1.0 create tab
            var page = new TabPage($"{host.Name}[{host.FullAddress}]");
            tabMain.TabPages.Add(page);
            page.ContextMenuStrip = menuTabPage;
            tabMain.SelectedTab = page;
            #endregion

            #region 2.0 Create a remote desktop client
            var rdpClient = new AxMsRdpClient9NotSafeForScripting
            {
                Dock = DockStyle.None,
                Width = page.Width,
                Height = page.Height
            };
            page.Controls.Add(rdpClient);

            rdpClient.Server = host.Address;
            if (host.Port != 3389)
                rdpClient.AdvancedSettings2.RDPPort = host.Port;

            rdpClient.UserName = host.Username;
            rdpClient.AdvancedSettings2.ClearTextPassword = host.Pwd;

            #region Remote Mode [Desktop/Program Only]
            if (string.IsNullOrEmpty(host.RemoteProgram)) //normal remote desktop mode
            {
                rdpClient.SecuredSettings3.KeyboardHookMode = 1;
            }
            else
            {
                rdpClient.RemoteProgram2.RemoteProgramMode = true;
                rdpClient.Width = Screen.PrimaryScreen.Bounds.Width;
                rdpClient.Height = Screen.PrimaryScreen.Bounds.Height;
                rdpClient.OnLoginComplete += (o, args) =>
                {
                    rdpClient.RemoteProgram2.ServerStartProgram(host.RemoteProgram, "", "%SYSTEMROOT%", false, "", false);
                    rdpClient.OnRemoteProgramResult += (o1, args1) =>
                    {
                        if (args1.lError != RemoteProgramResult.remoteAppResultOk)
                        {
                            rdpClient.Dispose();
                            MessageBox.Show(args1.lError.ToString(), "Failed to open remote program");
                        }
                    };

                    tabMain.TabPages.Remove(page);
                };
            }
            #endregion

            /*
               rdpClient.Width = Screen.PrimaryScreen.Bounds.Width;
               rdpClient.Height = Screen.PrimaryScreen.Bounds.Height;
               rdpClient.AdvancedSettings9.SmartSizing = true;
             */

            var clientNonScriptable = (IMsRdpClientNonScriptable5)rdpClient.GetOcx();
            clientNonScriptable.PromptForCredentials = false;
            rdpClient.AdvancedSettings9.EnableCredSspSupport = true;
            rdpClient.ColorDepth = 16;
            rdpClient.ConnectingText = $"Connecting[{host.Name}]，Please Wait... {host.FullAddress}";

            //( Windows Server 2003 )
            rdpClient.AdvancedSettings9.ConnectToAdministerServer = host.Ext.ConnectSession0;

            #region Shared local disk [Configurable]

            rdpClient.AdvancedSettings9.RedirectDrives = host.Ext.ShareAllDisk;

            if (!rdpClient.AdvancedSettings9.RedirectDrives)
            {
                var diskList = host.Ext.ShareDiskList;
                if (diskList?.Count > 0)
                {
                    var driveCollection = clientNonScriptable.DriveCollection;
                    for (uint i = 0; i < driveCollection.DriveCount; i++)
                    {
                        var driveByIndex = driveCollection.DriveByIndex[i];
                        var driveName = driveByIndex.Name.Substring(0, driveByIndex.Name.Length - 1);
                        driveByIndex.RedirectionState = diskList.Contains(driveName);
                    }
                }
            }
            #endregion

            #endregion

            //Connect to remote desktop
            rdpClient.Connect();
        }

        private AxMsRdpClient9NotSafeForScripting GetHost(int pageIndex)
        {
            var page = tabMain.TabPages[pageIndex];
            return (AxMsRdpClient9NotSafeForScripting)page.Controls[0];
        }


        #region Menu Button

        /// <summary>
        /// Switch theme
        /// </summary>
        private void btnChangeStyle_Click(object sender, EventArgs e)
        {
            var nextStyle = ((int)metroStyleManager.Style + 1) % 14;
            if (nextStyle == 1) nextStyle++; //Ignore white

            metroStyleManager.Style = (MetroColorStyle)nextStyle;

            Db.Connection.Execute("UPDATE MyConfig SET FValue=@Style WHERE FKey='Style'", new { metroStyleManager.Style });

            Refresh();
        }

        /// <summary>
        /// To refresh
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHosts();
        }

        /// <summary>
        /// Add host
        /// </summary>
        private void btnAddRemoteHost_Click(object sender, EventArgs e)
        {
            var hostForm = new RemoteHostForm { StyleManager = metroStyleManager };
            if (hostForm.ShowDialog() == DialogResult.OK)
                LoadHosts();
        }

        /// <summary>
        /// Global Settings
        /// </summary>
        private void btnGlobalSetting_Click(object sender, EventArgs e)
        {
            var globalSettingForm = new GlobalSettingForm { StyleManager = metroStyleManager };
            globalSettingForm.ShowDialog();
        }

        /// <summary>
        /// About
        /// </summary>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/bierquelle06/RemoteDesktopManagement");
        }
        #endregion

        #region Tab control [drag/close]
        private void tabMain_MouseDown(object sender, MouseEventArgs e)
        {
            var index = InTabPageHead(e.Location, false);
            if (index > 0)
            {
                tabMain.SelectedIndex = index;

                if (e.Button == MouseButtons.Right)
                    tabMain.ContextMenuStrip = menuTabPage;
                else if (e.Button == MouseButtons.Left)
                {
                    _tabMoving = true;
                    _tabBeforeMoveX = e.X;
                }
            }
        }

        /// <summary>
        /// Moving TabPage position
        /// </summary>
        private bool _tabMoving;
        private int _tabBeforeMoveX;

        private void tabMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_tabMoving)
            {
                var index = InTabPageHead(e.Location, true);
                if (index <= 0)
                {
                    Cursor.Current = Cursors.No;
                    return;
                }

                var offset = e.X - _tabBeforeMoveX;
                if (offset == 0)
                {
                    Cursor.Current = Cursors.Default;
                    return;
                }

                Cursor.Current = Cursors.NoMoveHoriz;
                if (tabMain.SelectedIndex != index)
                {
                    var currPage = tabMain.SelectedTab;

                    tabMain.Visible = false;
                    tabMain.TabPages.Remove(currPage);
                    tabMain.TabPages.Insert(index, currPage);
                    tabMain.SelectedTab = currPage;
                    tabMain.Visible = true;
                }
            }
        }

        private int InTabPageHead(Point location, bool zoomRange)
        {
            for (int i = 1, count = tabMain.TabPages.Count; i < count; i++) //Exclude home page
            {
                var rect = tabMain.GetTabRect(i);
                if (zoomRange) //Narrow the scope of judgment
                {
                    var offset = rect.Width / 4;
                    rect = new Rectangle(rect.X + offset / 2, rect.Y, rect.Width - offset, rect.Height);
                }

                if (rect.Contains(location))
                {
                    return i;
                }
            }
            return -1;
        }

        private void tabMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //finished dragging
            {
                _tabMoving = false;
                Cursor.Current = Cursors.Default;
            }
            else if (e.Button == MouseButtons.Middle) //close tab
            {
                var index = InTabPageHead(e.Location, true);
                if (index <= 0) return;

                CloseHost(index);
            }
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            tabMain.ContextMenuStrip = null;  //Cancel menu after leaving tab
        }

        private void tmiCloseHost_Click(object sender, EventArgs e)
        {
            CloseHost(tabMain.SelectedIndex);
        }

        private void CloseHost(int pageIndex)
        {
            var page = tabMain.TabPages[pageIndex];
            var host = GetHost(pageIndex);

            if (host.Connected == 1)
                host.Disconnect();
            host.Dispose();
            tabMain.TabPages.Remove(page);

            tabMain.SelectedIndex = pageIndex - (pageIndex == tabMain.TabPages.Count ? 1 : 0);
        }
        #endregion

        #region Metro Title
        /// <summary>
        /// Host
        /// </summary>
        private MetroTile _currSelectHost;
        private void MenuTitleRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                _currSelectHost = (MetroTile)sender;
        }

        private void tmiHostEdit_Click(object sender, EventArgs e)
        {
            if (_currSelectHost == null) return;

            var host = (RemoteHost)_currSelectHost.Tag;
            var hostForm = new RemoteHostForm { StyleManager = metroStyleManager, RemoteHost = host };

            if (hostForm.ShowDialog() == DialogResult.OK)
                LoadHosts();
        }

        private void tmiDeleteHost_Click(object sender, EventArgs e)
        {
            if (_currSelectHost == null) return;

            var host = (RemoteHost)_currSelectHost.Tag;
            Db.Connection.Execute("DELETE FROM RemoteHost WHERE Id=" + host.Id);

            _currSelectHost.Parent.Controls.Remove(_currSelectHost);
            _currSelectHost = null;
        }

        private void tmiDeleteAll_Click(object sender, EventArgs e)
        {
            if (_currSelectHost == null) return;

            var host = (RemoteHost)_currSelectHost.Tag;
            Db.Connection.Execute("DELETE FROM RemoteHost WHERE ParentId=" + host.ParentId);
            Db.Connection.Execute("DELETE FROM RemoteHost WHERE Id=" + host.ParentId);

            var parent = _currSelectHost.Parent.Parent;
            parent.Parent.Controls.Remove(parent);
            _currSelectHost = null;
        }

        private HostGroupBox _currSelectGroup;

        private void tmiGropEdit_Click(object sender, EventArgs e)
        {
            if (_currSelectGroup == null) return;

            var host = (RemoteHost)_currSelectGroup.Tag;
            var hostForm = new RemoteHostForm { StyleManager = metroStyleManager, RemoteHost = host };

            if (hostForm.ShowDialog() == DialogResult.OK)
                LoadHosts();
        }

        private void tmiGroupDelete_Click(object sender, EventArgs e)
        {
            if (_currSelectGroup == null) return;

            var host = (RemoteHost)_currSelectGroup.Tag;
            Db.Connection.Execute("DELETE FROM RemoteHost WHERE ParentId=" + host.Id);
            Db.Connection.Execute("DELETE FROM RemoteHost WHERE Id=" + host.Id);

            _currSelectGroup.Parent = null;
            _currSelectGroup = null;
        }
        #endregion

        #region Interface switch and wake up [Switch mapped keyboard]
        private int _keyboardHookModeChanged;
        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (_keyboardHookModeChanged == 1) return;
            _keyboardHookModeChanged = 1;
            if (tabMain.SelectedIndex <= 0) return;

            var host = GetHost(tabMain.SelectedIndex);
            if (host.RemoteProgram2.RemoteProgramMode) return;

            host.SecuredSettings3.KeyboardHookMode = 1; //Apply key combination on remote server。
        }
        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (_keyboardHookModeChanged == 2) return;
            _keyboardHookModeChanged = 2;
            if (tabMain.SelectedIndex <= 0) return;

            var host = GetHost(tabMain.SelectedIndex);
            if (host.RemoteProgram2.RemoteProgramMode) return;

            host.SecuredSettings3.KeyboardHookMode = 2; //Applies the key combination to the remote server only when the client is running in full screen mode. It's the default value.
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            for (var count = tabMain.TabPages.Count; count > 1;)
            {
                CloseHost(--count);
            }
        }


        #endregion

    }
}

