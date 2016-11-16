using MetroFramework;
using MetroFramework.Forms;
using System;
using System.IO;
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

            if (MainForm.SaveData[1] == "light")
            {
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                this.Theme = StyleManager.Theme;
            }

            if (MainForm.SaveData[1] == "dark")
            {
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.Theme = StyleManager.Theme;
            }
        }

        #endregion Form Load

        #region Form Controls

        private void Exit_Click(object sender, EventArgs e)
        {
            MainForm.SaveData[0] = UsernameTextBox.Text;
            (Application.OpenForms["Mainform"] as MainForm).ReloadPage();
            this.Close();
        }

        private void DeleteXP_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Clicking ok will delete all cached data stored over this last month. Are you sure? ", "Delete saved XP data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MainForm.SaveData[2] = "13";
            }
        }

        private void DeleteImage_Click(object sender, EventArgs e)
        {
            File.Delete(@"Profile.gif");
        }

        private void Light_Click(object sender, EventArgs e)
        {
            MainForm.SaveData[1] = "light";
        }

        private void Dark_Click(object sender, EventArgs e)
        {
            MainForm.SaveData[1] = "dark";
        }

        private void Red_Click(object sender, EventArgs e)
        {
            MainForm.SaveData[2] = "red";
        }

        private void Default_Click(object sender, EventArgs e)
        {
            MainForm.SaveData[2] = "blue";
        }

        private void Green_Click(object sender, EventArgs e)
        {
            MainForm.SaveData[2] = "green";
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            MainForm.SaveData[2] = "orange";
        }

        #endregion Form Controls
    }
}