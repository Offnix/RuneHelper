using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static string Username;
        public Form1()
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
                    StreamReader File = new StreamReader(@"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt");
                    Username = File.ReadToEnd();
                    File.Close();                 
                    ProfilePicture.Load("http://services.runescape.com/m=avatar-rs/" + Username + "/chat.gif");
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
        public void UpdatePage()
        {
           ProfilePicture.Load("http://services.runescape.com/m=avatar-rs/" + Username + "/chat.gif");
        }
    }
}
