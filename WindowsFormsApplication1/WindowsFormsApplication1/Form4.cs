using System;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace RsThing
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string result;
        string[] WCArray;
        string[] LevelArray;

        // tree to exp order = tree/evergreen/achery tree,oak,willow,teak,maple,hollow wood,hollow bark,mahoghany,artic pine,eucalyptus,ivy, yew, magic, cursed magic, bloodwood, elder, Bamboo,crystal,golden bamboo
        public static float[] WoodCutXpArray = new float[] { 25, 37.5f, 67.5f, 85, 100, 82.5f, 357.7f, 125, 140.2f, 165, 332.5f, 175, 250, 275, 320, 325, 120, 434.5f, 655.5f };
         /// <summary>
         /// Forms Buttons
         /// </summary>
        private void CharSearchButton_Click(object sender, EventArgs e)
        {
            string Name = CharNameBox.Text;
            string result = GetPlayerWoodcuttingXP(Name);
            XPBox.Text = result;
            ShowBoxes();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void CachedName_Click(object sender, EventArgs e)
        {
            CharNameBox.Text = MainForm.Username;
            result = GetPlayerWoodcuttingXP(MainForm.Username);
            XPBox.Text = result;
            ShowBoxes();
        }

        /// <summary>
        /// Functions
        /// </summary>
        private void ShowBoxes()
        {
            TargetLevelLabel.Visible = true;
            TargetBox.Visible = true;
            BonusXPlabel.Visible = true;
            BonusBox.Visible = true;
            TreeTypeBox.Visible = true;
            CalculateBtn.Visible = true;
        }

        private String GetPlayerWoodcuttingXP(string Name)
        {
            try
            {
                string url = "http://services.runescape.com/m=hiscore/index_lite.ws?player=X";
                string NewUrl = url.Replace("X", Name);
                string textFromFile = (new System.Net.WebClient()).DownloadString(NewUrl);
                LevelArray = textFromFile.Split('\n');
                WCArray = LevelArray[17].Split(',');
                return WCArray[2];
            }
            catch
            {
                MessageBox.Show("Username was not found in the runescape highscores. Or highscores or are offline", "ERROR");
            }
            return null;
        }

        private void Calculate()
        {
            try
            {
                double NeededXP;

                int XP = Convert.ToInt32(XPBox.Text) + Convert.ToInt32(BonusBox.Text);
                int Level = Convert.ToInt32(WCArray[1]);

                NeededXP = API.LevelXpArray[Level + 1] - XP;

                int i = Level + 1;

                while (i <= Convert.ToInt32(TargetBox.Text))
                {
                    NeededXP = NeededXP + API.LevelXpArray[i];
                    i++;
                }
                AmountBox.Text = Convert.ToString(Math.Round(NeededXP / WoodCutXpArray[TreeTypeBox.SelectedIndex]));
                AmountBox.Visible = true;
            }
            catch
            {
                MessageBox.Show("Could not run calculation, please check all fields have been filled with no text", "ERROR");
            }
            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

