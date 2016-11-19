using MetroFramework.Forms;
using System;
using System.Text;

namespace RuneHelper
{
    public partial class QuickLaunch : MetroForm
    {
        public QuickLaunch()
        {
            InitializeComponent();
        }

        #region Open And Close functions

        private void QuickLaunch_Load(object sender, EventArgs e)
        {
            if (MainForm.SaveData[1] == "light")
            {
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            }

            if (MainForm.SaveData[1] == "dark")
            {
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.Theme = StyleManager.Theme;
            }
            StyleManager.Style = API.GetColour(MainForm.SaveData[2]);
        }

        #endregion Open And Close functions

        #region Forms Controls

        private void Launch_Click(object sender, EventArgs e)
        {
            StringBuilder b = new StringBuilder(Input.Text);
            System.Diagnostics.Process.Start("http://runescape.wikia.com/wiki/Special:Search?search=" + b.Replace(" ", "+"));
            this.Close();
        }

        #endregion Forms Controls
    }
}