﻿namespace RemoteDesktopManagement.Control
{
    partial class HostGroupBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelText = new System.Windows.Forms.Panel();
            this.lbText = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.Body = new System.Windows.Forms.FlowLayoutPanel();
            this.panelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.lbText);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelText.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.panelText.Location = new System.Drawing.Point(0, 0);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(306, 32);
            this.panelText.TabIndex = 0;
            // 
            // lbText
            // 
            this.lbText.AutoScroll = true;
            this.lbText.AutoScrollMinSize = new System.Drawing.Size(142, 30);
            this.lbText.AutoSize = false;
            this.lbText.BackColor = System.Drawing.SystemColors.Window;
            this.lbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbText.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.lbText.Location = new System.Drawing.Point(0, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(306, 32);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "<b><font face=\"Microsoft Yahei\" size=\"18\">Test group name</font></b>";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.htmlLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.htmlLabel2.Location = new System.Drawing.Point(0, 32);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(31, 102);
            this.htmlLabel2.TabIndex = 1;
            // 
            // Body
            // 
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(31, 32);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(275, 102);
            this.Body.TabIndex = 2;
            // 
            // HostGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Body);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.panelText);
            this.Name = "HostGroupBox";
            this.Size = new System.Drawing.Size(306, 134);
            this.panelText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelText;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private System.Windows.Forms.FlowLayoutPanel Body;
        private MetroFramework.Drawing.Html.HtmlLabel lbText;
    }
}
