using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace RuneHelper
{
    public partial class Welcome : MetroForm
    {
        public Welcome()
        {
            InitializeComponent();
        }

        public class Data
        {
            public string Name { get; set; }
            public string Clan { get; set; }
            public MetroFramework.MetroThemeStyle Theme { get; set; }
            public MetroFramework.MetroColorStyle Colour { get; set; }
            public int Month { get; set; }
            public int[] XPArray { get; set; }
        }

        #region Load And Close Function

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
        }

        #endregion Load And Close Function

        #region Form Controls

        private void ConfirmInput_Click(object sender, EventArgs e)
        {
            Data data = new Data();

            data.Name = UsernameInput.Text;
            data.Clan = "";
            data.Theme = MetroFramework.MetroThemeStyle.Light;
            data.Colour = MetroFramework.MetroColorStyle.Blue;
            data.Month = DateTime.Now.Month;
            data.XPArray = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            using (FileStream fs = File.Open(@"Data.txt", FileMode.Open))
            using (StreamWriter sw = new StreamWriter(fs))
            using (JsonWriter jw = new JsonTextWriter(sw))
            {
                jw.Formatting = Formatting.Indented;

                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(jw, data);
            }
            MainForm Mainform = new MainForm();
            Mainform.Show();
            this.Close();
        }

        #endregion Form Controls
    }
}