﻿namespace RemoteDesktopManagement
{
    partial class RemoteHostForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chIsParent = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.numSort = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.cbParent = new MetroFramework.Controls.MetroComboBox();
            this.lbStatus = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.pnlBottom = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pnlHost = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.chShareAllDisk = new MetroFramework.Controls.MetroToggle();
            this.gbDisks = new System.Windows.Forms.GroupBox();
            this.flpDisks = new System.Windows.Forms.FlowLayoutPanel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.txtRemoteProgram = new System.Windows.Forms.TextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.chConnectSession0 = new MetroFramework.Controls.MetroToggle();
            this.lbCopy = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.pnlHost.SuspendLayout();
            this.gbDisks.SuspendLayout();
            this.flpDisks.SuspendLayout();
            this.SuspendLayout();
            // 
            // chIsParent
            // 
            this.chIsParent.DisplayStatus = false;
            this.chIsParent.Location = new System.Drawing.Point(123, 16);
            this.chIsParent.Name = "chIsParent";
            this.chIsParent.Size = new System.Drawing.Size(75, 26);
            this.chIsParent.TabIndex = 0;
            this.chIsParent.Text = "~StatusOff";
            this.chIsParent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chIsParent.UseSelectable = true;
            this.chIsParent.UseVisualStyleBackColor = true;
            this.chIsParent.CheckedChanged += new System.EventHandler(this.cbIsParent_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Is it the parent";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 11;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 65);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Name";
            // 
            // numSort
            // 
            this.numSort.InterceptArrowKeys = false;
            this.numSort.Location = new System.Drawing.Point(348, 64);
            this.numSort.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSort.Name = "numSort";
            this.numSort.Size = new System.Drawing.Size(122, 20);
            this.numSort.TabIndex = 13;
            this.numSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(291, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "To Sort";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(268, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 34);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(123, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 34);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbParent
            // 
            this.cbParent.FormattingEnabled = true;
            this.cbParent.ItemHeight = 23;
            this.cbParent.Location = new System.Drawing.Point(312, 13);
            this.cbParent.Name = "cbParent";
            this.cbParent.Size = new System.Drawing.Size(158, 29);
            this.cbParent.TabIndex = 16;
            this.cbParent.UseSelectable = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(310, 29);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(51, 19);
            this.lbStatus.TabIndex = 18;
            this.lbStatus.Text = "[Status]";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(279, 56);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 19);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = "Password";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(24, 55);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(68, 19);
            this.metroLabel6.TabIndex = 34;
            this.metroLabel6.Text = "Username";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 10);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "Address";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(280, 11);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(34, 19);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "Port";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(123, 11);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 20);
            this.txtAddress.TabIndex = 27;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(348, 56);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '●';
            this.txtPwd.Size = new System.Drawing.Size(122, 20);
            this.txtPwd.TabIndex = 31;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(123, 55);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(121, 20);
            this.txtUser.TabIndex = 30;
            this.txtUser.Text = "Administrator";
            // 
            // numPort
            // 
            this.numPort.InterceptArrowKeys = false;
            this.numPort.Location = new System.Drawing.Point(348, 10);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(122, 20);
            this.numPort.TabIndex = 29;
            this.numPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPort.Value = new decimal(new int[] {
            3389,
            0,
            0,
            0});
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.HorizontalScrollbarBarColor = true;
            this.pnlBottom.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBottom.HorizontalScrollbarSize = 11;
            this.pnlBottom.Location = new System.Drawing.Point(20, 481);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(499, 64);
            this.pnlBottom.TabIndex = 20;
            this.pnlBottom.VerticalScrollbarBarColor = true;
            this.pnlBottom.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBottom.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.cbParent);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.chIsParent);
            this.metroPanel1.Controls.Add(this.numSort);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtName);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 11;
            this.metroPanel1.Location = new System.Drawing.Point(20, 65);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(499, 105);
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pnlHost
            // 
            this.pnlHost.Controls.Add(this.label1);
            this.pnlHost.Controls.Add(this.metroLabel9);
            this.pnlHost.Controls.Add(this.metroLabel8);
            this.pnlHost.Controls.Add(this.chShareAllDisk);
            this.pnlHost.Controls.Add(this.gbDisks);
            this.pnlHost.Controls.Add(this.txtRemoteProgram);
            this.pnlHost.Controls.Add(this.metroLabel10);
            this.pnlHost.Controls.Add(this.metroLabel7);
            this.pnlHost.Controls.Add(this.chConnectSession0);
            this.pnlHost.Controls.Add(this.metroLabel5);
            this.pnlHost.Controls.Add(this.metroLabel6);
            this.pnlHost.Controls.Add(this.txtPwd);
            this.pnlHost.Controls.Add(this.metroLabel4);
            this.pnlHost.Controls.Add(this.numPort);
            this.pnlHost.Controls.Add(this.txtAddress);
            this.pnlHost.Controls.Add(this.txtUser);
            this.pnlHost.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHost.HorizontalScrollbarBarColor = true;
            this.pnlHost.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlHost.HorizontalScrollbarSize = 11;
            this.pnlHost.Location = new System.Drawing.Point(20, 170);
            this.pnlHost.Name = "pnlHost";
            this.pnlHost.Size = new System.Drawing.Size(499, 311);
            this.pnlHost.TabIndex = 22;
            this.pnlHost.VerticalScrollbarBarColor = true;
            this.pnlHost.VerticalScrollbarHighlightOnWheel = false;
            this.pnlHost.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(280, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Valid only in 2003";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(24, 153);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(90, 19);
            this.metroLabel9.TabIndex = 49;
            this.metroLabel9.Text = "Share all disks";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(26, 102);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(122, 19);
            this.metroLabel8.TabIndex = 38;
            this.metroLabel8.Text = "Start program only";
            // 
            // chShareAllDisk
            // 
            this.chShareAllDisk.DisplayStatus = false;
            this.chShareAllDisk.Location = new System.Drawing.Point(123, 152);
            this.chShareAllDisk.Name = "chShareAllDisk";
            this.chShareAllDisk.Size = new System.Drawing.Size(60, 26);
            this.chShareAllDisk.TabIndex = 48;
            this.chShareAllDisk.Text = "~StatusOff";
            this.chShareAllDisk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chShareAllDisk.UseSelectable = true;
            this.chShareAllDisk.UseVisualStyleBackColor = true;
            // 
            // gbDisks
            // 
            this.gbDisks.Controls.Add(this.flpDisks);
            this.gbDisks.Location = new System.Drawing.Point(26, 198);
            this.gbDisks.Name = "gbDisks";
            this.gbDisks.Size = new System.Drawing.Size(444, 98);
            this.gbDisks.TabIndex = 47;
            this.gbDisks.TabStop = false;
            this.gbDisks.Text = "Set up shared disks individually";
            // 
            // flpDisks
            // 
            this.flpDisks.Controls.Add(this.metroCheckBox1);
            this.flpDisks.Location = new System.Drawing.Point(6, 22);
            this.flpDisks.Name = "flpDisks";
            this.flpDisks.Size = new System.Drawing.Size(432, 69);
            this.flpDisks.TabIndex = 0;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(3, 3);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(31, 15);
            this.metroCheckBox1.TabIndex = 0;
            this.metroCheckBox1.Text = "C";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.UseVisualStyleBackColor = true;
            // 
            // txtRemoteProgram
            // 
            this.txtRemoteProgram.Location = new System.Drawing.Point(154, 101);
            this.txtRemoteProgram.Name = "txtRemoteProgram";
            this.txtRemoteProgram.Size = new System.Drawing.Size(316, 20);
            this.txtRemoteProgram.TabIndex = 36;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(277, 152);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(112, 19);
            this.metroLabel10.TabIndex = 46;
            this.metroLabel10.Text = "Connect session 0";
            // 
            // chConnectSession0
            // 
            this.chConnectSession0.DisplayStatus = false;
            this.chConnectSession0.Location = new System.Drawing.Point(395, 147);
            this.chConnectSession0.Name = "chConnectSession0";
            this.chConnectSession0.Size = new System.Drawing.Size(75, 26);
            this.chConnectSession0.TabIndex = 45;
            this.chConnectSession0.Text = "~StatusOff";
            this.chConnectSession0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chConnectSession0.UseSelectable = true;
            this.chConnectSession0.UseVisualStyleBackColor = true;
            // 
            // lbCopy
            // 
            this.lbCopy.AutoSize = true;
            this.lbCopy.ForeColor = System.Drawing.Color.Blue;
            this.lbCopy.Location = new System.Drawing.Point(361, 29);
            this.lbCopy.Name = "lbCopy";
            this.lbCopy.Size = new System.Drawing.Size(48, 19);
            this.lbCopy.TabIndex = 23;
            this.lbCopy.Text = "[Copy]";
            this.lbCopy.UseCustomForeColor = true;
            this.lbCopy.Visible = false;
            this.lbCopy.Click += new System.EventHandler(this.lbCopy_Click);
            // 
            // RemoteHostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 567);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.lbCopy);
            this.Controls.Add(this.pnlHost);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lbStatus);
            this.Name = "RemoteHostForm";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.Resizable = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remote host configuration";
            this.Load += new System.EventHandler(this.RemoteHostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.pnlHost.ResumeLayout(false);
            this.pnlHost.PerformLayout();
            this.gbDisks.ResumeLayout(false);
            this.flpDisks.ResumeLayout(false);
            this.flpDisks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroToggle chIsParent;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown numSort;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton  btnSave;
        private MetroFramework.Controls.MetroComboBox cbParent;
        private MetroFramework.Controls.MetroLabel lbStatus;
        private MetroFramework.Controls.MetroPanel pnlBottom;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.NumericUpDown numPort;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel pnlHost;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.TextBox txtRemoteProgram;
        private MetroFramework.Controls.MetroLabel lbCopy;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroToggle chShareAllDisk;
        private System.Windows.Forms.GroupBox gbDisks;
        private System.Windows.Forms.FlowLayoutPanel flpDisks;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroToggle chConnectSession0;
        private System.Windows.Forms.Label label1;
    }
}