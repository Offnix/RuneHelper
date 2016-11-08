using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Linq;

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
        private void Form1_Load(object sender, EventArgs e)
        {
            SaveData = API.StreamReader(@"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt").Split(',');
            ReloadPage();       
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Form Controls
        private void GraphUpdate_Click(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            API.StreamWriter(string.Join(",",SaveData), @"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt");
            Application.Exit();
        }
        #endregion

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
        #endregion

        #region Context Menu
        private void OpenStats_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://services.runescape.com/m=hiscore/compare?user1=" + SaveData[0].Replace(" ","+"));
        }
        #endregion

        #region Functions
        public void ReloadPage()
        {
            Cursor.Current = Cursors.WaitCursor;
            XPTracker.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            try
            {
                ProfilePicture.Load("http://services.runescape.com/m=avatar-rs/" + SaveData[0] + "/chat.gif");              
            }
            catch
            {
                ProfilePicture.Load("http://services.runescape.com/m=avatar-rs/default_chat.png?");
            }
            
            try
            {

                LevelArray = API.UpdateLevels(SaveData[0]);
                UsernameLabel.Text = SaveData[0];
                AverageLevel.Text =  API.GetMean(LevelArray).ToString();
                TotalLevel.Text =  LevelArray[1];
                PercentageLabel.Text = API.GetLevelPercentage(Convert.ToInt32(LevelArray[1])) + "%";
                CombatLevel.Text = API.GetCombatLvl(LevelArray).ToString();
                UpdateGraph();

                // find a way to minify this and your a god amongst men
                //progress bars
                AttackBar.Value = Convert.ToInt32(LevelArray[3]);
                DefenceBar.Value = Convert.ToInt32(LevelArray[5]);
                StrengthBar.Value = Convert.ToInt32(LevelArray[7]);
                HealthBar.Value = Convert.ToInt32(LevelArray[9]);
                RangedBar.Value = Convert.ToInt32(LevelArray[11]);
                PrayerBar.Value = Convert.ToInt32(LevelArray[13]);
                MagicBar.Value = Convert.ToInt32(LevelArray[15]);
                CookingBar.Value = Convert.ToInt32(LevelArray[17]);
                WoodcuttingBar.Value = Convert.ToInt32(LevelArray[19]);
                FletchingBar.Value = Convert.ToInt32(LevelArray[21]);
                FishingBar.Value = Convert.ToInt32(LevelArray[23]);
                FiremakingBar.Value = Convert.ToInt32(LevelArray[25]);
                CraftingBar.Value = Convert.ToInt32(LevelArray[27]);
                SmithingBar.Value = Convert.ToInt32(LevelArray[29]);
                MiningBar.Value = Convert.ToInt32(LevelArray[31]);
                HerbloreBar.Value = Convert.ToInt32(LevelArray[33]);
                AgilityBar.Value = Convert.ToInt32(LevelArray[35]);
                ThievingBar.Value = Convert.ToInt32(LevelArray[37]);
                SlayerBar.Value = Convert.ToInt32(LevelArray[39]);
                FarmingBar.Value = Convert.ToInt32(LevelArray[41]);
                RunecraftingBar.Value = Convert.ToInt32(LevelArray[43]);
                HunterBar.Value = Convert.ToInt32(LevelArray[45]);
                ConstructionBar.Value = Convert.ToInt32(LevelArray[47]);
                SummoningBar.Value = Convert.ToInt32(LevelArray[49]);
                DungeoneeringBar.Value = Convert.ToInt32(LevelArray[51]);
                DivinationBar.Value = Convert.ToInt32(LevelArray[53]);
                InventorBar.Value = Convert.ToInt32(LevelArray[55]);
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

            int count = 2;
            string[] arraysplit = LevelArray[2].Split('\n');
            SaveData[DateTime.Now.Day + 1] = arraysplit[0];

            if(DateTime.Now.Month != Convert.ToInt32(SaveData[1]))
            {
                SaveData[1] = DateTime.Now.Month.ToString();
                while(count < SaveData.Length)
                {
                    SaveData[count] = "0";
                    count++;
                }
            }
            count = 2;
            while(count < SaveData.Length)
            {
                if (string.IsNullOrEmpty(SaveData[count]) == false && SaveData[count] != "0")
                {
                    Console.WriteLine(SaveData[count]);
                    XPTracker.Series[0].Points.AddXY(count, Convert.ToInt32(SaveData[count]));
                }
                count++;
            }
        }
        #endregion
    }
}
