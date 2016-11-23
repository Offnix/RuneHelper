using System;
using System.IO;
using System.Net;
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

    #region IO Functions

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

    public static bool CheckFileIntegrity()
    {
        if (File.Exists(@"Data.txt") == false)
        {
            File.Create(@"Data.txt").Close();
            return true;
        }
        return false;
    }

    #endregion IO Functions

    #region Webclient Functions

    public static string[] UpdateLevels(String Username)
    {
        try
        {
            WebClient Download = new WebClient();
            Download.Proxy = null;
            string RawExp = (Download.DownloadString("http://services.runescape.com/m=hiscore/index_lite.ws?player=" + Username));
            Download.Dispose();
            return RawExp.Split(',');
        }
        catch
        {
            MessageBox.Show("ERROR: Username was not found in the runescape  highscores or highscores or are offline", "RuneHelper");
        }
        return null;
    }

    public static string[] GetStats(string Name)
    {
        string[] LevelArray;
        try
        {
            WebClient Download = new WebClient();
            Download.Proxy = null;
            string textFromFile = (Download.DownloadString("http://services.runescape.com/m=hiscore/index_lite.ws?player=" + Name));
            LevelArray = textFromFile.Split('\n');
            Download.Dispose();
            return LevelArray;
        }
        catch
        {
            MessageBox.Show("ERROR: Username was not found in the runescape highscores. Or highscores or are offline", "RuneHelper");
            return null;
        }
    }

    public static void UpdateImage(string Username)
    {
        WebClient Download = new WebClient();
        Download.Proxy = null;
        Download.DownloadFile("http://services.runescape.com/m=avatar-rs/" + Username + "/chat.gif", Username + ".gif");
        Download.Dispose();
    }

    #endregion Webclient Functions

    #region Calculator Functions

    public static string GetLevelPercentage(decimal TotalLevel)
    {
        decimal percentage;
        percentage = Math.Round(TotalLevel / 2715m, 2);
        return Convert.ToInt32(percentage * 100).ToString();
    }

    public static int GetCombatLvl(string[] LevelArray)
    {
        int Attack = IntParse(LevelArray[3]);
        int Strength = IntParse(LevelArray[5]);
        int Defence = IntParse(LevelArray[7]);
        int Ranged = IntParse(LevelArray[11]);
        int Magic = IntParse(LevelArray[17]);
        int Hp = IntParse(LevelArray[9]);
        int Prayer = IntParse(LevelArray[13]);
        int Summoning = IntParse(LevelArray[49]);

        double Melee = Attack + Strength;
        double Range = Math.Floor(2.0 * Ranged);
        double Mage = Math.Floor(2.0 * Magic);
        double High = Math.Max(Math.Max(Melee, Mage), Range);

        double cmb = Math.Floor(1.3 * High) + Defence + Hp + Math.Floor(Prayer / 2.0) + Math.Floor(Summoning / 2.0);
        return Convert.ToInt32(Math.Floor(cmb / 4.0));
    }

    public static int IntParse(string value)
    {
        int result = 0;
        for (int i = 0; i < value.Length; i++)
        {
            result = 10 * result + (value[i] - 48);
        }
        return result;
    }

    public static int GetMean(String[] LevelArray)
    {
        int i = 3;
        int total = 0;
        try
        {
            while (i != 55)
            {
                total = total + API.IntParse(LevelArray[i]);
                i = i + 2;
            }
            return total / 27;
        }
        catch
        {
            return 0;
        }
    }

    #endregion Calculator Functions

    #region Style Functions

    public static MetroFramework.MetroColorStyle GetColour(string Colour)
    {
        switch (Colour)
        {
            case "red":
                return MetroFramework.MetroColorStyle.Red;

            case "blue":
                return MetroFramework.MetroColorStyle.Blue;

            case "green":
                return MetroFramework.MetroColorStyle.Green;

            case "orange":
                return MetroFramework.MetroColorStyle.Orange;

            case "silver":
                return MetroFramework.MetroColorStyle.Silver;

            case "brown":
                return MetroFramework.MetroColorStyle.Brown;

            case "pink":
                return MetroFramework.MetroColorStyle.Pink;

            case "purple":
                return MetroFramework.MetroColorStyle.Purple;
        }
        return MetroFramework.MetroColorStyle.Default;
    }

    public static MetroFramework.MetroThemeStyle GetTheme(string Theme)
    {
        if (Theme == "light")
        {
            return MetroFramework.MetroThemeStyle.Light;
        }

        if (Theme == "dark")
        {
            return MetroFramework.MetroThemeStyle.Dark;
        }

        return MetroFramework.MetroThemeStyle.Default;
    }

    #endregion Style Functions
}

#region Designer Functions

public class CustomToolStripProfessionalRenderer : ToolStripProfessionalRenderer
{
    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    {
    }
}

#endregion Designer Functions