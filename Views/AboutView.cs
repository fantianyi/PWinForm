using System;
using System.Diagnostics;
using PWinForm;

namespace System.Windows.Forms
{
    public partial class AboutView : BaseView
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lbl_version.Text = Application.ProductVersion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.gnu.org/copyleft/gpl.html");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:erik@vcage.com");
        }
    }
}
