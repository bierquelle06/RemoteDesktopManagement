﻿using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework.MessageBox;
using Newtonsoft.Json;
using RemoteDesktopManagement.Model;

namespace RemoteDesktopManagement
{
    public partial class RemoteHostForm : MetroForm
    {
        public RemoteHostForm()
        {
            InitializeComponent();
        }

        public RemoteHost RemoteHost { get; set; }

        private bool IsModify => RemoteHost != null;

        private void RemoteHostForm_Load(object sender, System.EventArgs e)
        {
            //设置主题
            chIsParent.StyleManager = StyleManager;
            chConnectSession0.StyleManager = StyleManager;
            chShareAllDisk.StyleManager = StyleManager;

            //共享设置
            chConnectSession0.Checked = GlobalConfig.Instance.ConnectSession0;
            chShareAllDisk.CheckedChanged += (o, args) => gbDisks.Enabled = !chShareAllDisk.Checked;
            chShareAllDisk.Checked = GlobalConfig.Instance.ShareAllDisk;

            //可用磁盘
            flpDisks.Controls.Clear();
            foreach (var driveInfo in DriveInfo.GetDrives())
            {
                flpDisks.Controls.Add(new MetroCheckBox
                {
                    Text = driveInfo.Name,
                    AutoSize = true,
                    StyleManager = StyleManager,
                    Checked = GlobalConfig.Instance.ShareDiskList.Contains(driveInfo.Name)
                });
            }

            //Suppress up and down buttons
            numSort.Controls.RemoveAt(0);

            //Load parent node drop-down box information
            LoadParentComboBox();

            //Do you need to load information
            if (IsModify)
                LoadRemoteHost();
            else
                txtName.Select();
        }

        private void LoadParentComboBox()
        {
            var parents = Db.Connection.Query<RemoteHost>("SELECT Id,Name FROM RemoteHost WHERE ParentId=0 ORDER BY Sort");
            cbParent.DisplayMember = "Name";
            cbParent.ValueMember = "Id";
            cbParent.DataSource = parents;
        }

        private void LoadRemoteHost()
        {
            lbStatus.Text = "[修改]";

            chIsParent.Checked = RemoteHost.ParentId == 0;
            chIsParent.Enabled = false; //不允许修改节点类型

            cbParent.SelectedValue = RemoteHost.ParentId;
            txtName.Text = RemoteHost.Name;
            numSort.Value = RemoteHost.Sort;

            txtAddress.Text = RemoteHost.Address;
            numPort.Value = RemoteHost.Port;
            txtUser.Text = RemoteHost.Username;
            txtPwd.Text = RemoteHost.Pwd;
            txtRemoteProgram.Text = RemoteHost.RemoteProgram;

            chConnectSession0.Checked = RemoteHost.Ext.ConnectSession0;
            chShareAllDisk.Checked = RemoteHost.Ext.ShareAllDisk;
            foreach (var ch in flpDisks.Controls.OfType<MetroCheckBox>())
            {
                ch.Checked = RemoteHost.Ext.ShareDiskList.Contains(ch.Text);
            }

            lbCopy.Visible = true; //显示复制按钮
        }

        private void lbCopy_Click(object sender, EventArgs e)
        {
            RemoteHost = null;
            lbCopy.Visible = false;
            lbStatus.Text = "[新增]";
            chIsParent.Enabled = true;
        }

        private void cbIsParent_CheckedChanged(object sender, EventArgs e)
        {
            cbParent.Visible = pnlHost.Visible = !chIsParent.Checked;

            if (chIsParent.Checked)
            {
                Height -= pnlHost.Height;
            }
            else
            {
                Height += pnlHost.Height;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Trim();
            if (txtName.TextLength <= 0)
            {
                MetroMessageBox.Show(this, "Please fill in the name！");
                txtName.Focus();
                txtName.SelectAll();
                return;
            }
            if (!chIsParent.Checked && cbParent.SelectedIndex < 0)
            {
                MetroMessageBox.Show(this, "Please select a parent！");
                cbParent.DroppedDown = true;
                return;
            }

            var host = new RemoteHost
            {
                Name = txtName.Text,
                Sort = Convert.ToInt32(numSort.Value),
            };
            if (!chIsParent.Checked)
            {
                host.ParentId = Convert.ToInt32(cbParent.SelectedValue);
                host.Address = txtAddress.Text.Trim();
                host.Port = Convert.ToInt32(numPort.Value);
                host.Username = txtUser.Text.Trim();
                host.Pwd = txtPwd.Text;
                host.RemoteProgram = txtRemoteProgram.Text.Trim();

                host.Ext.ConnectSession0 = chConnectSession0.Checked;
                host.Ext.ShareAllDisk = chShareAllDisk.Checked;
                host.Ext.ShareDiskList = flpDisks.Controls.OfType<MetroCheckBox>().Where(ch => ch.Checked).Select(ch => ch.Text).ToList();

                host.ExtJson = JsonConvert.SerializeObject(host.Ext);
            }

            Db.Connection.Execute(
                IsModify
                    ? @"UPDATE RemoteHost SET Name=@Name,Address=@Address,Port=@Port,Username=@Username,Pwd=@Pwd,Sort=@Sort,ParentId=@ParentId,
                        RemoteProgram=@RemoteProgram,ExtJson=@ExtJson WHERE Id=" + RemoteHost.Id

                    : @"INSERT INTO RemoteHost(Name,Address,Port,Username,Pwd,Sort,ParentId,RemoteProgram,ExtJson) 
                        VALUES(@Name,@Address,@Port,@Username,@Pwd,@Sort,@ParentId,@RemoteProgram,@ExtJson)",
                host);


            DialogResult = DialogResult.OK;
        }


    }
}
