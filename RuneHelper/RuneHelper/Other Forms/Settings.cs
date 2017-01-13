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
            UsernameTextBox.Text = MainForm.data.Name;
            StyleManager.Theme = MainForm.data.Theme;
            StyleManager.Style = MainForm.data.Colour;
            this.Theme = StyleManager.Theme;
        }

        #endregion Form Load

        #region Form Controls

        private void Exit_Click(object sender, EventArgs e)
        {
            MainForm.data.Name = UsernameTextBox.Text;
            (Application.OpenForms["Mainform"] as MainForm).ReloadPage();
            this.Close();
        }

        private void DeleteXP_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Clicking ok will delete all cached data stored over this last month. Are you sure? ", "Delete saved XP data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MainForm.data.Month = 13;
            }
        }

        private void DeleteImage_Click(object sender, EventArgs e)
        {
            File.Delete(MainForm.data.Name+".gif");
        }

        private void Light_Click(object sender, EventArgs e)
        {
            MainForm.data.Theme = MetroThemeStyle.Light;
        }

        private void Dark_Click(object sender, EventArgs e)
        {
            MainForm.data.Theme = MetroThemeStyle.Dark;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            MainForm.data.Colour = MetroColorStyle.Red;
        }

        private void Default_Click(object sender, EventArgs e)
        {
            MainForm.data.Colour = MetroColorStyle.Default;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            MainForm.data.Colour = MetroColorStyle.Green;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            MainForm.data.Colour = MetroColorStyle.Orange;
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            MainForm.data.Colour = MetroColorStyle.Pink;
        }

        private void Silver_Click(object sender, EventArgs e)
        {
            MainForm.data.Colour = MetroColorStyle.Silver;
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            MainForm.data.Colour = MetroColorStyle.Purple;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MainForm.data.Colour = MetroColorStyle.Purple;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            MainForm.data.Colour = MetroColorStyle.Blue;
        }

        #endregion Form Controls
    }
}