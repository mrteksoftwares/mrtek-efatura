using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTEK_EFatura
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin f = new frmLogin();
            f.ShowDialog();
            if (f.DialogResult != DialogResult.OK)
            {
                Application.ExitThread();
                return;
            }
            f.Dispose();

           Application.Run(new frmMain());
            
        }

    }
}
