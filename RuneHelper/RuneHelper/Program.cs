using System;
using System.Windows.Forms;

namespace RuneHelper
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (API.CheckFileIntegrity() == false)
            {
                MainForm M = new MainForm();
                M.Show();
            }
            else
            {
                Welcome W = new Welcome();
                W.Show();
            }
            Application.Run();
        }
    }
}