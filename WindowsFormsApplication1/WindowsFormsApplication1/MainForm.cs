using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public static string Username;
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
                    API.UpdateLevels();
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
            Form3 Settings = new Form3();
            Settings.Show();
        }

        private void ReloadPageToolStrip_Click(object sender, EventArgs e)
        {
            ReloadPage();
        }

        private void WoodcuttingToolStrip_Click(object sender, EventArgs e)
        {
            RsThing.Form4 Woodcut = new RsThing.Form4();
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

        /// <summary>
        /// Misc code/ functions
        /// </summary>

        public void ReloadPage()
        {
            ProfilePicture.Load("http://services.runescape.com/m=avatar-rs/" + Username + "/chat.gif");
            API.UpdateLevels();
            UsernameLabel.Text = Username;
            AverageLevel.Text = API.GetMean().ToString();
            TotalLevel.Text = API.LevelArray[1];

            // find a way to minify this and your a god amongst men
            //progress bars
            AttackBar.Value = Convert.ToInt32(API.LevelArray[5]);
            DefenceBar.Value = Convert.ToInt32(API.LevelArray[7]);
            StrengthBar.Value = Convert.ToInt32(API.LevelArray[9]);
            HealthBar.Value = Convert.ToInt32(API.LevelArray[11]);
            RangedBar.Value = Convert.ToInt32(API.LevelArray[13]);
            PrayerBar.Value = Convert.ToInt32(API.LevelArray[15]);
            MagicBar.Value = Convert.ToInt32(API.LevelArray[17]);
            WoodcuttingBar.Value = Convert.ToInt32(API.LevelArray[19]);
            FletchingBar.Value = Convert.ToInt32(API.LevelArray[21]);
            FishingBar.Value = Convert.ToInt32(API.LevelArray[23]);
            FiremakingBar.Value = Convert.ToInt32(API.LevelArray[25]);
            CraftingBar.Value = Convert.ToInt32(API.LevelArray[27]);
            SmithingBar.Value = Convert.ToInt32(API.LevelArray[29]);
            MiningBar.Value = Convert.ToInt32(API.LevelArray[31]);
            HerbloreBar.Value = Convert.ToInt32(API.LevelArray[33]);
            AgilityBar.Value = Convert.ToInt32(API.LevelArray[35]);
            ThievingBar.Value = Convert.ToInt32(API.LevelArray[37]);
            SlayerBar.Value = Convert.ToInt32(API.LevelArray[39]);
            FarmingBar.Value = Convert.ToInt32(API.LevelArray[41]);
            RunecraftingBar.Value = Convert.ToInt32(API.LevelArray[43]);
            HunterBar.Value = Convert.ToInt32(API.LevelArray[45]);
            ConstructionBar.Value = Convert.ToInt32(API.LevelArray[47]);
            SummoningBar.Value = Convert.ToInt32(API.LevelArray[49]);
            DungeoneeringBar.Value = Convert.ToInt32(API.LevelArray[51]);
            DivinationBar.Value = Convert.ToInt32(API.LevelArray[53]);
            InventorBar.Value = Convert.ToInt32(API.LevelArray[55]);
            //labels
            AttackLabel.Text = API.LevelArray[5];
            DefenceLabel.Text = API.LevelArray[7];
            StrengthLabel.Text = API.LevelArray[9];
            HealthLabel.Text = API.LevelArray[11];
            RangedLabel.Text = API.LevelArray[13];
            PrayerLabel.Text = API.LevelArray[15];
            MagicLabel.Text = API.LevelArray[17];
            WoodcuttingLabel.Text = API.LevelArray[19];
            FletchingLabel.Text = API.LevelArray[21];
            FishingLabel.Text = API.LevelArray[23];
            FiremakingLabel.Text = API.LevelArray[25];
            CraftingLabel.Text = API.LevelArray[27];
            SmithingLabel.Text = API.LevelArray[29];
            MiningLabel.Text = API.LevelArray[31];
            HerbloreLabel.Text = API.LevelArray[33];
            AgilityLabel.Text = API.LevelArray[35];
            ThievingLabel.Text = API.LevelArray[37];
            SlayerLabel.Text = API.LevelArray[39];
            FarmingLabel.Text = API.LevelArray[41];
            RunecraftingLabel.Text = API.LevelArray[43];
            HunterLabel.Text = API.LevelArray[45];
            ConstructionLabel.Text = API.LevelArray[47];
            SummoningLabel.Text = API.LevelArray[49];
            DungeoneeringLabel.Text = API.LevelArray[51];
            DivinationLabel.Text = API.LevelArray[53];
            InventionLabel.Text = API.LevelArray[55];
        }

        private void inventionPerkMetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RuneHelper.Form1 InventionForm = new RuneHelper.Form1();
            InventionForm.Show();
        }
    }
}
