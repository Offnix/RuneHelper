using System;
using MetroFramework.Forms;
using System.IO;

namespace RuneHelper.Calculators
{
    public partial class Welcome : MetroForm
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing";

            if (Directory.Exists(path) == true && File.Exists(path + @"\Data.txt") == true)
            {
                RuneHelper.MainForm Mainform = new RuneHelper.MainForm();
                Mainform.Show();
                this.Close();
            }

            if (Directory.Exists(path) == false && File.Exists(path + @"\Data.txt") == false)
            {
                Directory.CreateDirectory(path);
                File.Create(path + @"\Data.txt").Close();
            }
           }

        private void ConfirmInput_Click(object sender, EventArgs e)
        {
            API.StreamWriter(UsernameInput.Text, @"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt");
            RuneHelper.MainForm Mainform = new RuneHelper.MainForm();
            Mainform.Show();
            this.Close();
        }
    }
}
