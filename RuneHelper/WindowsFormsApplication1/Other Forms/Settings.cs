using MetroFramework.Forms;
using System;


namespace RuneHelper
{
    public partial class SettingsForm : MetroForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        #region Form Load
        private void Form3_Load(object sender, EventArgs e)
        {
            UsernameTextBox.Text = MainForm.Username;
        }
        #endregion

        #region Form Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            API.StreamWriter(UsernameTextBox.Text, @"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt");
            MainForm.Username = UsernameTextBox.Text;
            // to be fixed MainForm.UpdatePage();
            this.Close();
        }
        #endregion
    }
}
