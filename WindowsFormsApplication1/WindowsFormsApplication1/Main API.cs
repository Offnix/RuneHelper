using System;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApplication1;

public static class API
{
    public static string[] LevelArray;
    // this array being here is temporary until i create the woodcutting calc form!!!
    // tree to exp order = tree/evergreen/achery tree,oak,willow,teak,maple,hollow wood,hollow bark,mahoghany,artic pine,eucalyptus,ivy, yew, magic, cursed magic, bloodwood, elder, Bamboo,crystal,golden bamboo
    public static float[] WoodCutXpArray = new float[] { 25, 37.5f, 67.5f, 85, 100, 82.5f, 357.7f, 125, 140.2f, 165, 332.5f, 175, 250, 275, 320, 325, 120, 434.5f, 655.5f };

    public static double[] LevelXpArray = new double[] { 0, 0, 83, 174, 276, 388, 512, 650, 801, 969, 1154, 1358, 1584, 1833, 2107, 2411, 2746, 3115, 3523, 3973, 4470
                            , 5018, 5624, 6291, 7028, 7842, 8740, 9730, 10824, 12031, 13363, 14833, 16456, 18247, 20224, 22406, 24815
                            , 27473, 30408, 33648, 37224, 41171, 45529, 50339, 55649, 61512, 67983, 75127, 83014, 91721, 101333
                            , 111945, 123660, 136594, 150872, 166636, 184040, 203254, 224466, 247886, 273742, 302228, 333804, 368599
                            , 407015, 449428, 496254, 547953, 605032, 668051, 737627, 814445, 899257, 992895, 1096278, 1210421, 1336443
                            , 1475581, 1629200, 1798808, 1986068, 2192818, 2421087, 2673114, 2951373, 3258594, 3597792, 3972294, 4385776
                            , 4842295, 5346332, 5902831, 6517253, 7195629, 7944614, 8771558, 9684577, 10692629, 11805606, 13034431, 13034431};

    public static void StreamWriter(string WriteText, string FileLocation)
    {
        try
        {
        StreamWriter writer = new StreamWriter(FileLocation);
        writer.Write(WriteText);
        writer.Close();
        }
        catch
        {
            MessageBox.Show("File could not be accessed or doesnt exsist", "ERROR");
        }

    }

    public static string StreamReader(string FileLocation)
    {
        try
        {
            StreamReader Reader = new StreamReader(FileLocation);
            string text = Reader.ReadToEnd();
            Reader.Close();
            return text;
        }
        catch
        {
            MessageBox.Show("File could not be accessed or doesnt exsist", "ERROR");
            return "";
        }
    }


    public static void UpdateLevels()
    {
        try
        {
            string RawExp = (new System.Net.WebClient()).DownloadString("http://services.runescape.com/m=hiscore/index_lite.ws?player=" + MainForm.Username);
            LevelArray = RawExp.Split(',');
        }
        catch
        {
            MessageBox.Show("Username was not found in the runescape highscores or highscores or are offline", "ERROR");
        }
    }

    public static int GetMean()
    {
        int counter = 5;
        int total = 0;
        try
        {
            while (counter != 55)
            {
                total = total + Convert.ToInt32(LevelArray[counter]);
                counter = counter + 2;
            }
            return total / 27;
        }
        catch
        {
            MessageBox.Show("Error getting mean", "ERROR");
            return 0;
        }
        
    }
}