using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SilverhawkForm : Form
    {
        public SilverhawkForm()
        {
            InitializeComponent();
        }

        private void CharSearchButton_Click(object sender, EventArgs e)
        {
            string Name = CharNameBox.Text;
            string result;
            result = GetPlayerAgilityXP(Name);
            WebReturnBox.Text = result;
        }

        private String GetPlayerAgilityXP(string Name)
        {
            string url = "http://services.runescape.com/m=hiscore/index_lite.ws?player=X";
            string NewUrl = url.Replace("X", Name);
            var textFromFile = (new System.Net.WebClient()).DownloadString(NewUrl);
            string NewText = textFromFile.Replace(" ", "..");
            return textFromFile;
        }
    }
} 