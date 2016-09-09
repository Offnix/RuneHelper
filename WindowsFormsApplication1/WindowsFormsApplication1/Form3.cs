using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        /// <summary>
        /// on Form Load
        /// </summary>
        private void Form3_Load(object sender, EventArgs e)
        {
            UsernameTextBox.Text = MainForm.Username;
        }

        /// <summary>
        /// Form Buttons and functions
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            API.StreamWriter(UsernameTextBox.Text, @"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt");
            MainForm.Username = UsernameTextBox.Text;
            // to be fixed MainForm.UpdatePage();
            this.Close();
        }
    }
}
