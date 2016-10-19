using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

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
            UsernameTextBox.Text = MainForm.SaveData[0];
        }
        #endregion

        #region Form Controls
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.SaveData[0] = UsernameTextBox.Text;
            API.StreamWriter(string.Join(",",MainForm.SaveData), @"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt");
            MainForm.SaveData[0] = UsernameTextBox.Text;
            this.Close();
        }
        #endregion
    }
}
