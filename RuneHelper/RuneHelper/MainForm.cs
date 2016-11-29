using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuneHelper
{
    public partial class MainForm : MetroForm
    {
        public static string[] LevelArray;

        public static string[] SaveData = new string[35];

        public MainForm()
        {
            InitializeComponent();
            ClockRefresh.DoWork += new DoWorkEventHandler(ClockRefresh_DoWork);
        }

        #region Open and close Functions

        // loading point for everything needed in mainform
        private void MainForm_Load(object sender, EventArgs e)
        {
            MainToolStrip.Renderer = new CustomToolStripProfessionalRenderer();
            SaveData = API.StreamReader(@"Data.txt").Split(',');
            ClockRefresh.RunWorkerAsync();
            ReloadPage();
        }

        //Closing point for form and whole program. saves data and then closes
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ClockRefresh.Dispose();
            API.StreamWriter(string.Join(",", SaveData), @"Data.txt");
            Application.Exit();
        }

        #endregion Open and close Functions

        #region Form Controls

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GraphUpdate_Click(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        #endregion Form Controls

        #region Toolbar Controls

        private void AboutToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<About>().Any())
            {
                About AboutForm = new About();
                AboutForm.Show();
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

        private void CompareStatsToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<ComparePlayer>().Any())
            {
                ComparePlayer Compare = new ComparePlayer();
                Compare.Show();
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

        private void MiningToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<MiningCalc>().Any())
            {
                MiningCalc Mining = new MiningCalc();
                Mining.Show();
            }
        }

        private void OpenSettingsToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<SettingsForm>().Any())
            {
                SettingsForm Settings = new SettingsForm();
                Settings.Show();
            }
        }

        private void ReloadPageToolStrip_Click(object sender, EventArgs e)
        {
            ReloadPage();
        }

        private void silverHawkFeatherToolStrip_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<SilverhawkForm>().Any())
            {
                SilverhawkForm Silverhawk = new SilverhawkForm();
                Silverhawk.Show();
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

        private void itemSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<WooducttingCalculator>().Any())
            {
                ItemLookup lookup = new ItemLookup();
                lookup.Show();
            }
        }

        #endregion Toolbar Controls

        #region Context Menu

        private void BugsAndIssuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Peterburnett/RuneHelper/issues");
        }

        private void OpenStats_Click(object sender, EventArgs e)
        {
            StringBuilder b = new StringBuilder(SaveData[0]);
            Process.Start("http://runescape.wikia.com/wiki/Special:Search?search=" + b.Replace(" ", "+"));
        }

        private void SearchInWiki_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<QuickLaunch>().Any())
            {
                QuickLaunch Quick = new QuickLaunch();
                Quick.Show();
            }
        }

        #endregion Context Menu

        #region Functions

        public void ReloadPage()
        {
            Cursor.Current = Cursors.WaitCursor;

            var s1 = Stopwatch.StartNew();
            // run on seperate threads for time saving
            Task.Run(() => UpdateImage());
            Task.Run(() => UpdateGraph());
            // get and set theme and colour from api
            StyleManager.Theme = API.GetTheme(SaveData[1]);
            StyleManager.Style = API.GetColour(SaveData[2]);
            this.Theme = StyleManager.Theme;

            // load the UI
            try
            {
                UsernameLabel.Text = SaveData[0];
                LevelArray = API.UpdateLevels(SaveData[0]);
                TotalLevel.Text = LevelArray[1];
                AverageLevel.Text = API.GetMean(LevelArray).ToString();
                PercentageLabel.Text = API.GetLevelPercentage(Convert.ToDecimal(LevelArray[1])) + "%";
                CombatLevel.Text = API.GetCombatLvl(LevelArray).ToString();

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
                s1.Stop();
                Cursor.Current = Cursors.Default;
                Console.WriteLine(s1.ElapsedMilliseconds);
            }
            catch
            {
            }
        }

        public void UpdateGraph()
        {
            // this is used for changing the placement of the month savedata in the array.. for when the savedata gets extended
            int MonthSetting = 3;

            // changes graph style
            XPTracker.Invoke((MethodInvoker)(() =>
            {
                if (SaveData[1] == "light")
                {
                    XPTracker.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Black;
                    XPTracker.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Black;
                    XPTracker.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.Black;
                    XPTracker.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.Black;
                    XPTracker.ChartAreas[0].AxisX.LineColor = Color.Black;
                    XPTracker.ChartAreas[0].AxisY.LineColor = Color.Black;
                }

                if (SaveData[1] == "dark")
                {
                    XPTracker.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.White;
                    XPTracker.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.White;
                    XPTracker.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.White;
                    XPTracker.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.White;
                    XPTracker.ChartAreas[0].AxisX.LineColor = Color.White;
                    XPTracker.ChartAreas[0].AxisY.LineColor = Color.White;
                }

                foreach (var series in XPTracker.Series)
                {
                    series.Points.Clear();
                }
                try
                {
                    int i = MonthSetting + 1;
                    string[] arraysplit = LevelArray[2].Split('\n');
                    SaveData[DateTime.Now.Day + MonthSetting] = arraysplit[0];

                    // reset function
                    if (DateTime.Now.Month != API.IntParse(SaveData[MonthSetting]))
                    {
                        SaveData[MonthSetting] = DateTime.Now.Month.ToString();
                        while (i < SaveData.Length)
                        {
                            SaveData[i] = "0";
                            i++;
                        }
                    }

                    // Set data points
                    i = MonthSetting + 1;
                    bool first = true;
                    int Smallest = 0;
                    int largest = 0;
                    while (i < SaveData.Length)
                    {
                        if (string.IsNullOrEmpty(SaveData[i]) == false && SaveData[i] != "0")
                        {
                            XPTracker.Series[0].Points.AddXY(i - 3, API.IntParse(SaveData[i]));
                            if (first == true) { Smallest = API.IntParse(SaveData[i]); first = false; }
                            largest = API.IntParse(SaveData[i]);
                        }
                        i++;
                    }
                    XPMade.Text = Convert.ToString(largest - Smallest);
                }
                catch { }
            }));
        }

        // update the profile image 
        public void UpdateImage()
        {
            string FileName = SaveData[0] + ".gif";
            try
            {
                ProfilePicture.Load(FileName);
            }
            catch
            {
                if (File.Exists(FileName) == true)
                {
                    File.Delete(FileName);
                }
                else
                {
                    API.UpdateImage(SaveData[0]);
                    ProfilePicture.Load(FileName);
                }
            }
        }

        //seperate thread for refreshing the clock
        private void ClockRefresh_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (true)
                {
                    MainToolStrip.Invoke((MethodInvoker)(() =>
                    {
                        Time.Text = DateTime.UtcNow.ToString("HH:mm:ss tt");
                    }));
                    Thread.Sleep(1000);
                }
            }
            catch { }
        }

        #endregion Functions
    }
}