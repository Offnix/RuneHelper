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
            RuneHelper.Calculators.Welcome Welcome = new RuneHelper.Calculators.Welcome();
            Welcome.Show();
            Application.Run();
        }
    }
}
