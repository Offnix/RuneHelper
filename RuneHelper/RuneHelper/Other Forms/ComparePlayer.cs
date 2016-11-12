using System;
using System.Windows.Forms;

namespace RuneHelper
{
    public partial class ComparePlayer : Form
    {
        public string[] LevelArray;
        public string[] LevelArray2;

        public ComparePlayer()
        {
            InitializeComponent();
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            try
            {
                ProfileBox1.Load("http://services.runescape.com/m=avatar-rs/" + PLayerInput1.Text + "/chat.gif");
            }
            catch
            {
                ProfileBox1.Load("http://services.runescape.com/m=avatar-rs/default_chat.png?");
            }

            try
            {
                ProfileBox2.Load("http://services.runescape.com/m=avatar-rs/" + PlayerInput2.Text + "/chat.gif");
            }
            catch
            {
                ProfileBox2.Load("http://services.runescape.com/m=avatar-rs/default_chat.png?");
            }

            try
            {
                LevelArray = API.UpdateLevels(PLayerInput1.Text);
                LevelArray2 = API.UpdateLevels(PlayerInput2.Text);

                AttackBar.Value = API.IntParse(LevelArray[5]);
                DefenceBar.Value = API.IntParse(LevelArray[7]);
                StrengthBar.Value = API.IntParse(LevelArray[9]);
                HealthBar.Value = API.IntParse(LevelArray[11]);
                RangedBar.Value = API.IntParse(LevelArray[13]);
                PrayerBar.Value = API.IntParse(LevelArray[15]);
                MagicBar.Value = API.IntParse(LevelArray[17]);
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

                AttackBar2.Value = API.IntParse(LevelArray2[5]);
                DefenceBar2.Value = API.IntParse(LevelArray2[7]);
                StrengthBar2.Value = API.IntParse(LevelArray2[9]);
                HealthBar2.Value = API.IntParse(LevelArray2[11]);
                RangedBar2.Value = API.IntParse(LevelArray2[13]);
                PrayerBar2.Value = API.IntParse(LevelArray2[15]);
                MagicBar2.Value = API.IntParse(LevelArray2[17]);
                WoodcuttingBar2.Value = API.IntParse(LevelArray2[19]);
                FletchingBar2.Value = API.IntParse(LevelArray2[21]);
                FishingBar2.Value = API.IntParse(LevelArray2[23]);
                FiremakingBar2.Value = API.IntParse(LevelArray2[25]);
                CraftingBar2.Value = API.IntParse(LevelArray2[27]);
                SmithingBar2.Value = API.IntParse(LevelArray2[29]);
                MiningBar2.Value = API.IntParse(LevelArray2[31]);
                HerbloreBar2.Value = API.IntParse(LevelArray2[33]);
                AgilityBar2.Value = API.IntParse(LevelArray2[35]);
                ThievingBar2.Value = API.IntParse(LevelArray2[37]);
                SlayerBar2.Value = API.IntParse(LevelArray2[39]);
                FarmingBar2.Value = API.IntParse(LevelArray2[41]);
                RunecraftingBar2.Value = API.IntParse(LevelArray2[43]);
                HunterBar2.Value = API.IntParse(LevelArray2[45]);
                ConstructionBar2.Value = API.IntParse(LevelArray2[47]);
                SummoningBar2.Value = API.IntParse(LevelArray2[49]);
                DungeoneeringBar2.Value = API.IntParse(LevelArray2[51]);
                DivinationBar2.Value = API.IntParse(LevelArray2[53]);
                InventorBar2.Value = API.IntParse(LevelArray2[55]);
                //labels
                AttackLabel2.Text = LevelArray2[5];
                DefenceLabel2.Text = LevelArray2[7];
                StrengthLabel2.Text = LevelArray2[9];
                HealthLabel2.Text = LevelArray2[11];
                RangedLabel2.Text = LevelArray2[13];
                PrayerLabel2.Text = LevelArray2[15];
                MagicLabel2.Text = LevelArray2[17];
                WoodcuttingLabel2.Text = LevelArray2[19];
                FletchingLabel2.Text = LevelArray2[21];
                FishingLabel2.Text = LevelArray2[23];
                FiremakingLabel2.Text = LevelArray2[25];
                CraftingLabel2.Text = LevelArray2[27];
                SmithingLabel2.Text = LevelArray2[29];
                MiningLabel2.Text = LevelArray2[31];
                HerbloreLabel2.Text = LevelArray2[33];
                AgilityLabel2.Text = LevelArray2[35];
                ThievingLabel2.Text = LevelArray2[37];
                SlayerLabel2.Text = LevelArray2[39];
                FarmingLabel2.Text = LevelArray2[41];
                RunecraftingLabel2.Text = LevelArray2[43];
                HunterLabel2.Text = LevelArray2[45];
                ContructionLabel2.Text = LevelArray2[47];
                SummoningLabel2.Text = LevelArray2[49];
                DungeoneeringLabel2.Text = LevelArray2[51];
                DivinationLabel2.Text = LevelArray2[53];
                InventionLabel2.Text = LevelArray2[55];
                Cursor.Current = Cursors.Default;
            }
            catch
            {
            }
        }

        private void CachedName_Click(object sender, EventArgs e)
        {
            PLayerInput1.Text = MainForm.SaveData[0];
        }

        private void OpenStats_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://services.runescape.com/m=hiscore/compare?category_type=-1&user1=" + PLayerInput1.Text.Replace(" ", "+") + "&user2=" + PlayerInput2.Text.Replace(" ", "+"));
        }
    }
}