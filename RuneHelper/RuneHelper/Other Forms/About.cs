using System;
using MetroFramework.Forms;

namespace RuneHelper
{
    public partial class About : MetroForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void Github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Peterburnett/RSThing");
        }
    }
}
