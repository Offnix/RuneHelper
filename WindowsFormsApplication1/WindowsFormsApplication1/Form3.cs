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
            UsernameTextBox.Text = Form1.Username;
        }

        /// <summary>
        /// Form Buttons and functions
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Data = new StreamWriter(@"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt");
            Data.Write(UsernameTextBox.Text);
            Data.Close();
            Form1.Username = UsernameTextBox.Text;
            this.Hide();
        }
    }
}
