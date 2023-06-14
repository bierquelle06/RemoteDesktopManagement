using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RemoteDesktopManagement.Control
{
    public partial class HostGroupBox : UserControl
    {
        public HostGroupBox()
        {
            InitializeComponent();

            lbText.MouseDown += (sender, e) => GropNameMouseDown?.Invoke(this, e);
        }

        public event Action<HostGroupBox, MouseEventArgs> GropNameMouseDown;

        private string _text = "";
        [Description("Title Information")]
        public new string Text
        {
            get => _text;
            set
            {
                _text = value;
                lbText.Text = $"<b><font face=\"microsoft yahei\" size=\"18\">{_text}</font></b>";
            }
        }

        public void AddControl(System.Windows.Forms.Control control)
        {
            Body.Controls.Add(control);
        }

        public new ContextMenuStrip ContextMenuStrip
        {
            get => lbText.ContextMenuStrip;
            set => lbText.ContextMenuStrip = value;
        }
    }
}
