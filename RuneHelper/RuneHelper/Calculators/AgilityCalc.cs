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
        private string[] TempArray;
        private string[] LevelArray;

        private float[] XPArray = new float[] { 79.5f, 86.5f, 750, 1014, 775, 139.5f, 580, 571.5f, 380, 540, 704, 880, 1056, 1184, 1328, 2375, 725, 740.7f };

        #region Load And Close Functions

        private void AglilityCalc_Load(object sender, EventArgs e)
        {
            StyleManager.Theme = MainForm.data.Theme;
            StyleManager.Style = MainForm.data.Colour;
            this.Theme = StyleManager.Theme;
        }

        #endregion Load And Close Functions

        #region Form Buttons

        private void CharSearchButton_Click(object sender, EventArgs e)
        {
            string Name = CharNameBox.Text;
            string result = GetPlayerXP(Name);
            XPBox.Text = result;
            ShowBoxes();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void CachedName_Click(object sender, EventArgs e)
        {
            CharNameBox.Text = MainForm.data.Name;
            result = GetPlayerXP(MainForm.data.Name);
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
            BonusPercent.Visible = true;
            BonusPercentLabel.Visible = true;
            TypeBox.Visible = true;
            CalculateBtn.Visible = true;
        }

        private String GetPlayerXP(string Name)
        {
            try
            {
                LevelArray = API.GetStats(Name);
                TempArray = LevelArray[35].Split(',');
                return TempArray[2];
            }
            catch
            {
                MessageBox.Show("Username was not found in the runescape highscores.", "ERROR");
            }
            return null;
        }

        private void Calculate()
        {
            try
            {
                double NeededXP;
                int XP = API.IntParse(XPBox.Text) + API.IntParse(BonusBox.Text);
                double PercentBonus = Convert.ToInt32(BonusPercent.Text) / 100.00f;
                PercentBonus = XP * PercentBonus;
                XP += Convert.ToInt32(PercentBonus);
                NeededXP = API.LevelXpArray[API.IntParse(TargetBox.Text)] - XP;
                AmountBox.Text = Convert.ToString(Math.Round(NeededXP / XPArray[TypeBox.SelectedIndex]));
                AmountBox.Visible = true;
                AmountLabel.Visible = true;
            }
            catch
            {
                MessageBox.Show("Could not run calculation, please check all fields have been filled correctly", "ERROR");
            }
        }

        #endregion Functions
    }
}