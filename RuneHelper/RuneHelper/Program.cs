using System;
using System.Windows.Forms;

namespace RuneHelper
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
            Welcome Welcome = new Welcome();
            Welcome.Show();
            Application.Run();
        }
    }
}
