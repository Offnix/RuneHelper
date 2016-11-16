using MetroFramework.Forms;
using System;

namespace RuneHelper
{
    public partial class About : MetroForm
    {
        public About()
        {
            InitializeComponent();
        }

        #region Load And Close Functions

        private void About_Load(object sender, EventArgs e)
        {
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

        #endregion Load And Close Functions

        private void Github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Peterburnett/RSThing");
        }
    }
}