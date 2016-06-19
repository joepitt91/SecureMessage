using System;
using System.Windows.Forms;

namespace Secure_Message
{
    static class Program
    {
        static internal Account CurrentAcount;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CurrentAcount = new Account();
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.Yes)
            {
                Application.Run(new Inbox());
            }
            GC.Collect();
            GC.WaitForFullGCComplete();
            Application.Exit();
        }
    }
}
