using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PWinForm
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                // 加载插件
            }
            catch
            { }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
