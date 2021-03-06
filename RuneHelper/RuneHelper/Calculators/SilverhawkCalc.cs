﻿using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace RuneHelper
{
    public partial class SilverhawkForm : MetroForm
    {
        public SilverhawkForm()
        {
            InitializeComponent();
        }

        private int feathers = 0;
        private string result;
        private string[] LevelArray;
        private string[] AgilArray;

        private double[] FeatherXp = new double[] {0,6.2,6.9,7.7,8.5,9.3,10.4,12.3,12.7,14.9,15.3, 17,18.8,20.5,22.9,25.2,26.1,27.4,28.5,29.8,
                                           31,32.4,33.7,35.2,36.7,38.4,39.9,40.5,41.4,45.3,47.3,49.3,51.4,53.6,55.9,58.3,60.8,63.5,66.2,
                                            69.1,72,75.2,78.4,81.8,85.3,88.9,92.9,97,101.2,105.5,110.1,114.8,120,124.9,130.4,136.2,142.2,
                                           148.5,154.6,161.6,168.4,175.5,183.5,191.1,200.4,210.8,217.1,226.9,237.9,247,259.2,269.3,280.9,
                                            294.6,308.2,321.3,333.9,349.5,364.6,379.2,398,416.6,434.7,452.1,476.2,491.8,503.3,537.5,559.2,592.2,
                                            612.1,645.1,661.4,692.8,723.6,753.2,806.4,834.7,860.2,860.2};

        #region Load And Close Functions

        private void SilverhawkForm_Load(object sender, EventArgs e)
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
            result = GetPlayerAgilityXP(Name);
            WebReturnBox.Text = result;
            ShowBoxes();
        }

        private void CharNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                string Name = CharNameBox.Text;
                result = GetPlayerAgilityXP(Name);
                WebReturnBox.Text = result;
                ShowBoxes();
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            RunCalculation();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CachedName_Click(object sender, EventArgs e)
        {
            CharNameBox.Text = MainForm.data.Name;
            result = GetPlayerAgilityXP(MainForm.data.Name);
            WebReturnBox.Text = result;
            ShowBoxes();
        }

        #endregion Form Buttons

        #region Functions

        private String GetPlayerAgilityXP(string Name)
        {
            try
            {
                LevelArray = API.GetStats(Name);
                AgilArray = LevelArray[17].Split(',');
                return AgilArray[2];
            }
            catch
            {
            }
            return null;
        }

        private void ShowBoxes()
        {
            WebReturnBox.Visible = true;
            XpLabel.Visible = true;
            TargetBox.Visible = true;
            TargetLabel.Visible = true;
            CalculateButton.Visible = true;
            EnterBonusXP.Visible = true;
            BonusXP.Visible = true;
        }

        private void RunCalculation()
        {
            try
            {
                int CurrentLevel = API.IntParse(AgilArray[1]);
                double NextLevelXp = API.LevelXpArray[CurrentLevel + 1];
                double CurrentXp = API.IntParse(AgilArray[2]) + API.IntParse(BonusXP.Text);
                double difference = NextLevelXp - CurrentXp;
                feathers = feathers + Convert.ToInt32((difference / FeatherXp[CurrentLevel]));

                int i = CurrentLevel + 1;
                while (i <= (API.IntParse(TargetBox.Text)))
                {
                    double xp = API.LevelXpArray[i + 1] - API.LevelXpArray[i];
                    int FeathersNeeded = Convert.ToInt32(xp / FeatherXp[i]);
                    feathers = feathers + FeathersNeeded;
                    i++;
                }

                NeededLabel.Visible = true;
                NeededBox.Text = feathers.ToString();
                NeededBox.Visible = true;

                feathers = 0;
            }
            catch
            {
                MessageBox.Show("Could not run calculation, please check all fields have been filled in correctly", "ERROR");
            }

            #endregion Functions
        }
    }
}