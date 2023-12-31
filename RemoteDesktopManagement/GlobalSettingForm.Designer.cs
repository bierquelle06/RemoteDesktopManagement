﻿namespace RemoteDesktopManagement
{
    partial class GlobalSettingForm
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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chConnectSession0 = new MetroFramework.Controls.MetroToggle();
            this.gbDisks = new System.Windows.Forms.GroupBox();
            this.flpDisks = new System.Windows.Forms.FlowLayoutPanel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chShareAllDisk = new MetroFramework.Controls.MetroToggle();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDisks.SuspendLayout();
            this.flpDisks.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(243, 87);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 19);
            this.metroLabel7.TabIndex = 39;
            this.metroLabel7.Text = "Password";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(19, 87);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(68, 19);
            this.metroLabel6.TabIndex = 38;
            this.metroLabel6.Text = "Username";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(312, 87);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '●';
            this.txtPwd.Size = new System.Drawing.Size(122, 20);
            this.txtPwd.TabIndex = 37;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(93, 87);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(121, 20);
            this.txtUser.TabIndex = 36;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(209, 143);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Connect Session 0";
            // 
            // chConnectSession0
            // 
            this.chConnectSession0.DisplayStatus = false;
            this.chConnectSession0.Location = new System.Drawing.Point(329, 142);
            this.chConnectSession0.Name = "chConnectSession0";
            this.chConnectSession0.Size = new System.Drawing.Size(75, 26);
            this.chConnectSession0.TabIndex = 40;
            this.chConnectSession0.Text = "~StatusOff";
            this.chConnectSession0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chConnectSession0.UseSelectable = true;
            this.chConnectSession0.UseVisualStyleBackColor = true;
            // 
            // gbDisks
            // 
            this.gbDisks.Controls.Add(this.flpDisks);
            this.gbDisks.Location = new System.Drawing.Point(21, 195);
            this.gbDisks.Name = "gbDisks";
            this.gbDisks.Size = new System.Drawing.Size(420, 98);
            this.gbDisks.TabIndex = 42;
            this.gbDisks.TabStop = false;
            this.gbDisks.Text = "Set up shared disks individually";
            // 
            // flpDisks
            // 
            this.flpDisks.Controls.Add(this.metroCheckBox1);
            this.flpDisks.Location = new System.Drawing.Point(6, 22);
            this.flpDisks.Name = "flpDisks";
            this.flpDisks.Size = new System.Drawing.Size(401, 69);
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 44;
            this.metroLabel2.Text = "Share all disks";
            // 
            // chShareAllDisk
            // 
            this.chShareAllDisk.DisplayStatus = false;
            this.chShareAllDisk.Location = new System.Drawing.Point(118, 142);
            this.chShareAllDisk.Name = "chShareAllDisk";
            this.chShareAllDisk.Size = new System.Drawing.Size(69, 26);
            this.chShareAllDisk.TabIndex = 43;
            this.chShareAllDisk.Text = "~StatusOff";
            this.chShareAllDisk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chShareAllDisk.UseSelectable = true;
            this.chShareAllDisk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(246, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 34);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(113, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 34);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(211, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Valid only in 2003";
            // 
            // GlobalSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.chShareAllDisk);
            this.Controls.Add(this.gbDisks);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.chConnectSession0);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Name = "GlobalSettingForm";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Global Settings";
            this.Load += new System.EventHandler(this.GlobalSettingForm_Load);
            this.gbDisks.ResumeLayout(false);
            this.flpDisks.ResumeLayout(false);
            this.flpDisks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle chConnectSession0;
        private System.Windows.Forms.GroupBox gbDisks;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle chShareAllDisk;
        private System.Windows.Forms.FlowLayoutPanel flpDisks;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Label label1;
    }
}