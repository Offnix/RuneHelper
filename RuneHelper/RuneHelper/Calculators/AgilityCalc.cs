using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace RuneHelper
{
    public partial class AgilityCalc : MetroForm
    {
        public AgilityCalc()
        {
            InitializeComponent();
        }

        private string result;
        private string[] AgilArray;
        private string[] LevelArray;

        public static float[] CourseXPArray = new float[] { 79.5f, 86.5f, 750, 1014, 775, 139.5f, 580, 571.5f, 380, 540, 704, 880, 1056, 1184, 1328, 2375, 725, 740.7f };

        #region Load And Close Functions

        private void AglilityCalc_Load(object sender, EventArgs e)
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

        #region Form Buttons

        private void CharSearchButton_Click(object sender, EventArgs e)
        {
            string Name = CharNameBox.Text;
            string result = GetPlayerMiningXP(Name);
            XPBox.Text = result;
            ShowBoxes();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (API.IntParse(AgilArray[1]) < API.IntParse(TargetBox.Text))
            {
                Calculate();
            }
            else
            {
                MessageBox.Show("Target Level Cant be under or same as current level", "ERROR");
            }
        }

        private void CachedName_Click(object sender, EventArgs e)
        {
            CharNameBox.Text = MainForm.SaveData[0];
            result = GetPlayerMiningXP(MainForm.SaveData[0]);
            XPBox.Text = result;
            ShowBoxes();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Form Buttons

        #region Functions

        private void ShowBoxes()
        {
            TargetLevelLabel.Visible = true;
            TargetBox.Visible = true;
            BonusXPlabel.Visible = true;
            BonusBox.Visible = true;
            TypeBox.Visible = true;
            CalculateBtn.Visible = true;
        }

        private String GetPlayerMiningXP(string Name)
        {
            try
            {
                LevelArray = API.GetStats(Name);
                AgilArray = LevelArray[17].Split(',');
                return AgilArray[2];
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

                int XP = API.IntParse(XPBox.Text) + API.IntParse(BonusBox.Text);

                NeededXP = API.LevelXpArray[API.IntParse(TargetBox.Text)] - XP;

                AmountBox.Text = Convert.ToString(Math.Round(NeededXP / CourseXPArray[TypeBox.SelectedIndex]));
                AmountBox.Visible = true;
                LapsLabel.Visible = true;
            }
            catch
            {
                MessageBox.Show("Could not run calculation, please check all fields have been filled correctly", "ERROR");
            }
        }

        #endregion Functions
    }
}