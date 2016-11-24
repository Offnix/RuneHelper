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
            StyleManager.Theme = API.GetTheme(MainForm.SaveData[1]);
            StyleManager.Style = API.GetColour(MainForm.SaveData[2]);
            this.Theme = StyleManager.Theme;
        }

        #endregion Load And Close Functions

        #region Form Controls

        private void Github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Peterburnett/RSThing");
        }

        #endregion Form Controls
    }
}