using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace PWinForm
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StandardMainWindow_Load(object sender, EventArgs e)
        {
            btnAboutView.Tag = new AboutView() { MdiParent = this };
            btnConfigView.Tag = new BaseView() { MdiParent = this };
            btnControlView.Tag = new BaseView() { MdiParent = this };
            btnHelpView.Tag = new BaseView() { MdiParent = this };
            btnHomeView.Tag = new BaseView() { MdiParent = this };
            btnLogView.Tag = new BaseView() { MdiParent = this };
            
            btnAboutView.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Restart();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                var form = btn.Tag as Form;
                if (form != null)
                {
                    this.Text = btn.Text;
                    form.Show();
                    form.Focus();
                }
            }
        }
    }
}
