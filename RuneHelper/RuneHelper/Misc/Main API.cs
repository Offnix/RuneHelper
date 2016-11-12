using System;
using System.IO;
using System.Windows.Forms;

public static class API
{
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
            MessageBox.Show("ERROR: File could not be accessed or doesnt exsist", "RuneHelper");
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
            MessageBox.Show("ERROR: File could not be accessed or doesnt exsist", "RuneHelper");
            return "";
        }
    }

    public static string[] UpdateLevels(String Username)
    {
        try
        {
            string RawExp = (new System.Net.WebClient()).DownloadString("http://services.runescape.com/m=hiscore/index_lite.ws?player=" + Username);
            return RawExp.Split(',');
        }
        catch
        {
            MessageBox.Show("ERROR: Username was not found in the runescape  highscores or highscores or are offline", "RuneHelper");
        }
        return null;
    }

    public static int GetMean(String[] LevelArray)
    {
        int i = 3;
        int total = 0;
        try
        {
            while (i != 55)
            {
                total = total + Convert.ToInt32(LevelArray[i]);
                i = i + 2;
            }
            return total / 27;
        }
        catch
        {
            return 0;
        }
    }

    public static string[] GetStats(string Name)
    {
        string[] LevelArray;
        try
        {
            string textFromFile = (new System.Net.WebClient()).DownloadString("http://services.runescape.com/m=hiscore/index_lite.ws?player="+Name);
            LevelArray = textFromFile.Split('\n');
            return LevelArray;
        }
        catch
        {
            MessageBox.Show("ERROR: Username was not found in the runescape highscores. Or highscores or are offline", "RuneHelper");
            return null;
        }
    }

    public static bool CheckFileIntegrity()
    {
       string path = @"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing";

        if (Directory.Exists(path) == false)
        {
            Directory.CreateDirectory(path);
        }

        if (File.Exists(path + @"\Data.txt") == false)
        {
            File.Create(path + @"\Data.txt").Close();
            StreamWriter(" ,", path + @"\Data.txt");
            return true;
        }
        return false;
    }

    public static string GetLevelPercentage(decimal TotalLevel)
    {
        decimal percentage;
        percentage = Math.Round(TotalLevel / 2715m, 2);
        return Convert.ToInt32(percentage * 100).ToString();
    }

    public static int GetCombatLvl(string[] LevelArray)
    {
        int Attack = Convert.ToInt32(LevelArray[3]);
        int Strength = Convert.ToInt32(LevelArray[5]);
        int Defence = Convert.ToInt32(LevelArray[7]);
        int Ranged = Convert.ToInt32(LevelArray[11]);
        int Magic = Convert.ToInt32(LevelArray[17]);
        int Hp = Convert.ToInt32(LevelArray[9]);
        int Prayer = Convert.ToInt32(LevelArray[13]);
        int Summoning = Convert.ToInt32(LevelArray[49]);

        double Melee = Attack + Strength;
        double Range = Math.Floor(2.0 * Ranged);
        double Mage = Math.Floor(2.0 * Magic);
        double High = Math.Max(Math.Max(Melee, Mage), Range);

        double cmb = Math.Floor(1.3 * High) + Defence + Hp + Math.Floor(Prayer / 2.0) + Math.Floor(Summoning / 2.0);
        return Convert.ToInt32(Math.Floor(cmb / 4.0));
    }
}