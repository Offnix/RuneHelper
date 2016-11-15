﻿using MetroFramework.Forms;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RuneHelper
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static string[] SaveData = new string[33];
        public static string[] LevelArray;

        #region Open and close Functions

        private void MainForm_Load(object sender, EventArgs e)
        {
            SaveData = API.StreamReader(@"Data.txt").Split(',');
            ReloadPage();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            API.StreamWriter(string.Join(",", SaveData), @"Data.txt");
            Application.Exit();
        }

        #endregion Open and close Functions

        #region Form Controls

        private void GraphUpdate_Click(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            API.StreamWriter(string.Join(",", SaveData), @"Data.txt");
            Application.Exit();
        }

        #endregion Form Controls

        #region Toolbar Controls

        private void ReloadPageToolStrip_Click(object sender, EventArgs e)
        {
            ReloadPage();
        }

        private void OpenSettingsToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<SettingsForm>().Any())
            {
                SettingsForm Settings = new SettingsForm();
                Settings.Show();
            }
        }

        private void WoodcuttingToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<WooducttingCalculator>().Any())
            {
                WooducttingCalculator Woodcut = new WooducttingCalculator();
                Woodcut.Show();
            }
        }

        private void MiningToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<MiningCalc>().Any())
            {
                MiningCalc Mining = new MiningCalc();
                Mining.Show();
            }
        }

        private void AgilityToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<AgilityCalc>().Any())
            {
                AgilityCalc Agil = new AgilityCalc();
                Agil.Show();
            }
        }

        private void silverHawkFeatherToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<SilverhawkForm>().Any())
            {
                SilverhawkForm Silverhawk = new SilverhawkForm();
                Silverhawk.Show();
            }
        }

        private void AboutToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<About>().Any())
            {
                About AboutForm = new About();
                AboutForm.Show();
            }
        }

        private void FireMakingToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FireMakingCalc>().Any())
            {
                FireMakingCalc FireMaking = new FireMakingCalc();
                FireMaking.Show();
            }
        }

        private void InventionPerkMetaToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<InventionMeta>().Any())
            {
                InventionMeta InventionForm = new InventionMeta();
                InventionForm.Show();
            }
        }

        private void CompareStatsToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<ComparePlayer>().Any())
            {
                ComparePlayer Compare = new ComparePlayer();
                Compare.Show();
            }
        }

        #endregion Toolbar Controls

        #region Context Menu

        private void OpenStats_Click(object sender, EventArgs e)
        {
            StringBuilder b = new StringBuilder(SaveData[0]);
            System.Diagnostics.Process.Start("http://services.runescape.com/m=hiscore/compare?user1=" + b.Replace(" ", "+"));
        }

        #endregion Context Menu

        #region Functions

        public void ReloadPage()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                ProfilePicture.Load(@"Profile.gif");
            }
            catch
            {
                if(File.Exists(@"Profile.gif") == true)
                {
                    File.Delete("@Profile.gif");
                }
                else
                {
                    API.UpdateImage(SaveData[0]);
                    ProfilePicture.Load(@"Profile.gif");
                }
                
            }

            try
            {
                UsernameLabel.Text = SaveData[0];
                LevelArray = API.UpdateLevels(SaveData[0]);
                AverageLevel.Text = API.GetMean(LevelArray).ToString();
                TotalLevel.Text = LevelArray[1];
                PercentageLabel.Text = API.GetLevelPercentage(API.IntParse(LevelArray[1])) + "%";
                CombatLevel.Text = API.GetCombatLvl(LevelArray).ToString();
                UpdateGraph();

                // find a way to minify this and your a god amongst men
                //progress bars
                AttackBar.Value = API.IntParse(LevelArray[3]);
                DefenceBar.Value = API.IntParse(LevelArray[5]);
                StrengthBar.Value = API.IntParse(LevelArray[7]);
                HealthBar.Value = API.IntParse(LevelArray[9]);
                RangedBar.Value = API.IntParse(LevelArray[11]);
                PrayerBar.Value = API.IntParse(LevelArray[13]);
                MagicBar.Value = API.IntParse(LevelArray[15]);
                CookingBar.Value = API.IntParse(LevelArray[17]);
                WoodcuttingBar.Value = API.IntParse(LevelArray[19]);
                FletchingBar.Value = API.IntParse(LevelArray[21]);
                FishingBar.Value = API.IntParse(LevelArray[23]);
                FiremakingBar.Value = API.IntParse(LevelArray[25]);
                CraftingBar.Value = API.IntParse(LevelArray[27]);
                SmithingBar.Value = API.IntParse(LevelArray[29]);
                MiningBar.Value = API.IntParse(LevelArray[31]);
                HerbloreBar.Value = API.IntParse(LevelArray[33]);
                AgilityBar.Value = API.IntParse(LevelArray[35]);
                ThievingBar.Value = API.IntParse(LevelArray[37]);
                SlayerBar.Value = API.IntParse(LevelArray[39]);
                FarmingBar.Value = API.IntParse(LevelArray[41]);
                RunecraftingBar.Value = API.IntParse(LevelArray[43]);
                HunterBar.Value = API.IntParse(LevelArray[45]);
                ConstructionBar.Value = API.IntParse(LevelArray[47]);
                SummoningBar.Value = API.IntParse(LevelArray[49]);
                DungeoneeringBar.Value = API.IntParse(LevelArray[51]);
                DivinationBar.Value = API.IntParse(LevelArray[53]);
                InventorBar.Value = API.IntParse(LevelArray[55]);
                //labels
                AttackLabel.Text = LevelArray[3];
                DefenceLabel.Text = LevelArray[5];
                StrengthLabel.Text = LevelArray[7];
                HealthLabel.Text = LevelArray[9];
                RangedLabel.Text = LevelArray[11];
                PrayerLabel.Text = LevelArray[13];
                MagicLabel.Text = LevelArray[15];
                CookingLabel.Text = LevelArray[17];
                WoodcuttingLabel.Text = LevelArray[19];
                FletchingLabel.Text = LevelArray[21];
                FishingLabel.Text = LevelArray[23];
                FiremakingLabel.Text = LevelArray[25];
                CraftingLabel.Text = LevelArray[27];
                SmithingLabel.Text = LevelArray[29];
                MiningLabel.Text = LevelArray[31];
                HerbloreLabel.Text = LevelArray[33];
                AgilityLabel.Text = LevelArray[35];
                ThievingLabel.Text = LevelArray[37];
                SlayerLabel.Text = LevelArray[39];
                FarmingLabel.Text = LevelArray[41];
                RunecraftingLabel.Text = LevelArray[43];
                HunterLabel.Text = LevelArray[45];
                ConstructionLabel.Text = LevelArray[47];
                SummoningLabel.Text = LevelArray[49];
                DungeoneeringLabel.Text = LevelArray[51];
                DivinationLabel.Text = LevelArray[53];
                InventionLabel.Text = LevelArray[55];
                Cursor.Current = Cursors.Default;
            }
            catch
            {
            }
        }

        public void UpdateGraph()
        {
            foreach (var series in XPTracker.Series)
            {
                series.Points.Clear();
            }
            try
            {
                int i = 3;
                string[] arraysplit = LevelArray[2].Split('\n');
                SaveData[DateTime.Now.Day + 3] = arraysplit[0];

                if (DateTime.Now.Month != API.IntParse(SaveData[1]))
                {
                    SaveData[1] = DateTime.Now.Month.ToString();
                    while (i < SaveData.Length)
                    {
                        SaveData[i] = "0";
                        i++;
                    }
                }
                i = 3;
                while (i < SaveData.Length)
                {
                    if (string.IsNullOrEmpty(SaveData[i]) == false && SaveData[i] != "0")
                    {
                        XPTracker.Series[0].Points.AddXY(i - 3, API.IntParse(SaveData[i]));
                    }
                    i++;
                }
            }
            catch { }
        }
    }

    #endregion Functions
}