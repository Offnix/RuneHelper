using System;
using System.Windows.Forms;
using RuneHelper;
using MetroFramework.Forms;

namespace RsThing
{
    public partial class FireMakingCalc : MetroForm
    {
        public FireMakingCalc()
        {
            InitializeComponent();
        }
        string result;
        string[] WCArray;
        string[] LevelArray;

        public static float[] FireMakeXpArray = new float[] {25 ,37.5f ,67.5f ,105 ,125 ,135 ,157.5f ,171 ,202.5f ,303.8f ,435};

        #region Form Buttons
        private void CharSearchButton_Click(object sender, EventArgs e)
        {
            string Name = CharNameBox.Text;
            string result = GetPlayerFireMakingXP(Name);
            XPBox.Text = result;
            ShowBoxes();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(WCArray[1]) < Convert.ToInt32(TargetBox.Text))
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
            CharNameBox.Text = MainForm.Username;
            result = GetPlayerFireMakingXP(MainForm.Username);
            XPBox.Text = result;
            ShowBoxes();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Functions
        private void ShowBoxes()
        {
            TargetLevelLabel.Visible = true;
            TargetBox.Visible = true;
            BonusXPlabel.Visible = true;
            BonusBox.Visible = true;
            TreeTypeBox.Visible = true;
            CalculateBtn.Visible = true;
        }

        private String GetPlayerFireMakingXP(string Name)
        {
            try
            {
                LevelArray = API.GetStats(Name);
                WCArray = LevelArray[11].Split(',');
                return WCArray[2];
            }
            catch
            {
            }
            return null;
        }

        private void Calculate()
        {
            try
            {
                double NeededXP;
                int XP = Convert.ToInt32(XPBox.Text) + Convert.ToInt32(BonusBox.Text);
                NeededXP = API.LevelXpArray[Convert.ToInt32(TargetBox.Text)] - XP;              
                AmountBox.Text = Convert.ToString(Math.Round(NeededXP / FireMakeXpArray[TreeTypeBox.SelectedIndex]));
                AmountBox.Visible = true;
            }
            catch
            {
                MessageBox.Show("Could not run calculation, please check all fields have been filled with no text", "ERROR");
            }         
        }
        #endregion
    }
}

