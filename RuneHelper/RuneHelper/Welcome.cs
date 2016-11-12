using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace RuneHelper
{
    public partial class Welcome : MetroForm
    {
        public Welcome()
        {
            InitializeComponent();
        }

        #region Load And Close Function

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
        }

        #endregion Load And Close Function

        #region Form Controls

        private void ConfirmInput_Click(object sender, EventArgs e)
        {
            API.StreamWriter(UsernameInput.Text + "," + DateTime.Now.Month, @"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt");
            MainForm Mainform = new MainForm();
            Mainform.Show();
            this.Close();
        }

        #endregion Form Controls
    }
}