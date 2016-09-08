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
       // on main form finsihed loading
        private void Form1_Load(object sender, EventArgs e)
        {
            // if files dont exsist.... create them
            if (Directory.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing") == false && File.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt") == false)
            {
                //creating of files
                MessageBox.Show("Data file not found.. creating one now", "File Writer");
                Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing");
                File.Create(@"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt").Close();
            }
            else
            {
                // else if they already exsist and have more than 0 chars in it.. read the file and put it into a -
                // string array  split by commas
                if (new FileInfo(@"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt").Length > 0)
                {
                    Username = API.StreamReader(@"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt");                     
                    ProfilePicture.Load("http://services.runescape.com/m=avatar-rs/" + Username + "/chat.gif");
                    UsernameLabel.Text = Username;
                    API.UpdateLevels();
                    UpdateBars();
                }
            }           
        }

        /// <summary>
        /// Buttons on form
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            SilverhawkForm Silverhawk = new SilverhawkForm();
            Silverhawk.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Toolbar functions
        /// </summary>
        private void Settings_Click(object sender, EventArgs e)
        {
            Form3 Settings = new Form3();
            Settings.Show();
        }

        /// <summary>
        /// Misc code/ functions
        /// </summary>
        // THIS IS THE ISSUE RIGHT HERE
        public void UpdatePage()
        {
           ProfilePicture.Load("http://services.runescape.com/m=avatar-rs/" + Username + "/chat.gif");
            API.UpdateLevels();
            UsernameLabel.Text = Username;
            UpdateBars();
        }

        public void UpdateBars()
        {
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
        }
    }
}
