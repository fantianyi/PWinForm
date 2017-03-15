using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace PWinForm
{
    public partial class BaseView : Form
    {
        MainWindow Main 
        {
            get
            {
                return MdiParent as MainWindow;
            }
        }

        public BaseView()
        {
            InitializeComponent();
        }    
    }
}
