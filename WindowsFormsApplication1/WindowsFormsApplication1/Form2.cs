using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SilverhawkForm : Form
    {
        int feathers = 0;
        string result;
        string[] LevelArray;
        string[] AgilArray;
        double[] LevelXpArray = new double[] { 0, 0, 83, 174, 276, 388, 512, 650, 801, 969, 1154, 1358, 1584, 1833, 2107, 2411, 2746, 3115, 3523, 3973, 4470
                            , 5018, 5624, 6291, 7028, 7842, 8740, 9730, 10824, 12031, 13363, 14833, 16456, 18247, 20224, 22406, 24815
                            , 27473, 30408, 33648, 37224, 41171, 45529, 50339, 55649, 61512, 67983, 75127, 83014, 91721, 101333
                            , 111945, 123660, 136594, 150872, 166636, 184040, 203254, 224466, 247886, 273742, 302228, 333804, 368599
                            , 407015, 449428, 496254, 547953, 605032, 668051, 737627, 814445, 899257, 992895, 1096278, 1210421, 1336443
                            , 1475581, 1629200, 1798808, 1986068, 2192818, 2421087, 2673114, 2951373, 3258594, 3597792, 3972294, 4385776
                            , 4842295, 5346332, 5902831, 6517253, 7195629, 7944614, 8771558, 9684577, 10692629, 11805606, 13034431, 13034431};

        double[] FeatherXp = new double[] {0,6.2,6.9,7.7,8.5,9.3,10.4,12.3,12.7,14.9,15.3, 17,18.8,20.5,22.9,25.2,26.1,27.4,28.5,29.8,
                                           31,32.4,33.7,35.2,36.7,38.4,39.9,40.5,41.4,45.3,47.3,49.3,51.4,53.6,55.9,58.3,60.8,63.5,66.2,
                                            69.1,72,75.2,78.4,81.8,85.3,88.9,92.9,97,101.2,105.5,110.1,114.8,120,124.9,130.4,136.2,142.2,
                                           148.5,154.6,161.6,168.4,175.5,183.5,191.1,200.4,210.8,217.1,226.9,237.9,247,259.2,269.3,280.9,
                                            294.6,308.2,321.3,333.9,349.5,364.6,379.2,398,416.6,434.7,452.1,476.2,491.8,503.3,537.5,559.2,592.2,
                                            612.1,645.1,661.4,692.8,723.6,753.2,806.4,834.7,860.2,860.2};



        public SilverhawkForm()
        {
            InitializeComponent();
        }

        private void CharSearchButton_Click(object sender, EventArgs e)
        {
            string Name = CharNameBox.Text;
            result = GetPlayerAgilityXP(Name);
            WebReturnBox.Text = result;
            ShowBoxes();
        }

        private String GetPlayerAgilityXP(string Name)
        {
            string url = "http://services.runescape.com/m=hiscore/index_lite.ws?player=X";
            string NewUrl = url.Replace("X", Name);
            string textFromFile = (new System.Net.WebClient()).DownloadString(NewUrl);
            LevelArray = textFromFile.Split('\n');
            AgilArray = LevelArray[17].Split(',');
            return AgilArray[2];
            //So I managed to get it working by splitting the text after every \n character, then getting the 18th item in the array, which is agil
            //after that i seperated it into another array seperated by commas, then returned the 3rd item, which is the xp value alone
        }

        private void ShowBoxes()
        {
            WebReturnBox.Visible = true;
            XpLabel.Visible = true;
            TargetBox.Visible = true;
            TargetLabel.Visible = true;
            CalculateButton.Visible = true;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            RunCalculation();
        }

        private void RunCalculation()
        {
            int CurrentLevel = Convert.ToInt32(AgilArray[1]);
            double NextLevelXp = LevelXpArray[CurrentLevel + 1];
            double CurrentXp = Convert.ToInt32(AgilArray[2]);
            double difference = NextLevelXp - CurrentXp;
            feathers = feathers + Convert.ToInt32((difference / FeatherXp[CurrentLevel]));
            //First section Gets all the needed Values Sorted out, then gets the initial Feather count to the Next level

            int i = CurrentLevel + 1;
            while (i <= (Convert.ToInt32(TargetBox.Text)))
                {
                    double xp = LevelXpArray[i + 1] - LevelXpArray[i];
                    int FeathersNeeded =Convert.ToInt32(xp / FeatherXp[i]);
                    feathers = feathers + FeathersNeeded;
                    i++;
                }

            NeededLabel.Visible = true;
            NeededBox.Text = feathers.ToString();
            NeededBox.Visible = true;
        }
    }
} 