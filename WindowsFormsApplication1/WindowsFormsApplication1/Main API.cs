using System;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApplication1;

public static class API
{
    public static string[] LevelArray;

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
            return 0;
        }
        
    }
}