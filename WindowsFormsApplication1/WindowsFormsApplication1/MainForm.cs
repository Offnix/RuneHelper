using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public static string Username;
        public static string[] LevelArray;
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On form load
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing";
            if (Directory.Exists(path) == false && File.Exists(path +@"\Data.txt") == false)
            {
                MessageBox.Show("Data file not found.. creating one now", "File Writer");
                Directory.CreateDirectory(path);
                File.Create(path + @"\Data.txt").Close();
            }
            else
            {
                if (new FileInfo(path + @"\Data.txt").Length > 0)
                {
                    Username = API.StreamReader(path + @"\Data.txt");                     
                     LevelArray = API.UpdateLevels(Username);
                    ReloadPage();
                }
            }           
        }

        /// <summary>
        /// Buttons on form
        /// </summary>
 
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Toolbar functions
        /// </summary>

        private void OpenSettingsToolStrip_Click(object sender, EventArgs e)
        {
            SettingsForm Settings = new SettingsForm();
            Settings.Show();
        }

        private void ReloadPageToolStrip_Click(object sender, EventArgs e)
        {
            ReloadPage();
        }

        private void WoodcuttingToolStrip_Click(object sender, EventArgs e)
        {
            RsThing.WooducttingCalculator Woodcut = new RsThing.WooducttingCalculator();
            Woodcut.Show();
        }

        private void MiningToolStrip_Click(object sender, EventArgs e)
        {
            RsThing.Form6 Mining = new RsThing.Form6();
            Mining.Show();
        }

        private void AgilityToolStrip_Click(object sender, EventArgs e)
        {
            RsThing.Form6 Agil = new RsThing.Form6();
            Agil.Show();
        }

        private void silverHawkFeatherToolStrip_Click(object sender, EventArgs e)
        {
            SilverhawkForm Silverhawk = new SilverhawkForm();
            Silverhawk.Show();
        }

        private void AboutToolStrip_Click(object sender, EventArgs e)
        {
            RuneHelper.About AboutForm = new RuneHelper.About();
            AboutForm.Show();
        }

        private void FireMakingToolStrip_Click(object sender, EventArgs e)
        {
            RsThing.FireMakingCalc FireMaking = new RsThing.FireMakingCalc();
            FireMaking.Show();
        }

        private void InventionPerkMetaToolStrip_Click(object sender, EventArgs e)
        {
            RuneHelper.InventionMeta InventionForm = new RuneHelper.InventionMeta();
            InventionForm.Show();
        }

        private void CompareStatsToolStrip_Click(object sender, EventArgs e)
        {
            RuneHelper.ComparePlayer Compare = new RuneHelper.ComparePlayer();
            Compare.Show();
        }

        /// <summary>
        /// Misc code/ functions
        /// </summary>

        public void ReloadPage()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                ProfilePicture.Load("http://services.runescape.com/m=avatar-rs/" + Username + "/chat.gif");
            }
            catch
            {
                ProfilePicture.Load("http://services.runescape.com/m=avatar-rs/default_chat.png?");
            }
            
            try
            {
                LevelArray = API.UpdateLevels(Username);
                UsernameLabel.Text = Username;
                AverageLevel.Text =  API.GetMean(LevelArray).ToString();
                TotalLevel.Text =  LevelArray[1];

                // find a way to minify this and your a god amongst men
                //progress bars
                AttackBar.Value = Convert.ToInt32(LevelArray[5]);
                DefenceBar.Value = Convert.ToInt32(LevelArray[7]);
                StrengthBar.Value = Convert.ToInt32(LevelArray[9]);
                HealthBar.Value = Convert.ToInt32(LevelArray[11]);
                RangedBar.Value = Convert.ToInt32(LevelArray[13]);
                PrayerBar.Value = Convert.ToInt32(LevelArray[15]);
                MagicBar.Value = Convert.ToInt32(LevelArray[17]);
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
                AttackLabel.Text = LevelArray[5];
                DefenceLabel.Text = LevelArray[7];
                StrengthLabel.Text = LevelArray[9];
                HealthLabel.Text = LevelArray[11];
                RangedLabel.Text = LevelArray[13];
                PrayerLabel.Text = LevelArray[15];
                MagicLabel.Text = LevelArray[17];
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
    }
}
