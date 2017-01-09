using MetroFramework.Forms;
using System;
using System.Text;
using System.Windows.Forms;

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
            base.StyleManager.Theme = MainForm.data.Theme;
            base.StyleManager.Style = MainForm.data.Colour;
            this.Theme = base.StyleManager.Theme;
        }

        #endregion Open And Close functions

        #region Forms Controls

        private void Launch_Click(object sender, EventArgs e)
        {
            OpenForm();
        }

        #endregion Forms Controls

        #region Functions And Events

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                OpenForm();
            }
        }

        public void OpenForm()
        {
            StringBuilder b = new StringBuilder(Input.Text);
            System.Diagnostics.Process.Start("http://runescape.wikia.com/wiki/Special:Search?search=" + b.Replace(" ", "+"));
            this.Close();
        }

        #endregion Functions And Events
    }
}