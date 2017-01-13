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
            StyleManager.Theme = MainForm.data.Theme;
            StyleManager.Style = MainForm.data.Colour;
            this.Theme = StyleManager.Theme;
        }

        #endregion Load And Close Functions

        #region Form Controls

        private void Github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Offnix/RuneHelper");
        }

        #endregion Form Controls
    }
}