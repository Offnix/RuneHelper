﻿using System;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace RuneHelper.Calculators
{
    public partial class Welcome : MetroForm
    {
        public Welcome()
        {
            InitializeComponent();
        }

        #region Load And Close Function
        private void Welcome_Load(object sender, EventArgs e)
        {
            if(API.CheckFileIntegrity() == true)
            {

            }

            if (API.CheckFileIntegrity() == true)
            {
                MainForm Main = new MainForm();
                Main.Show();
                this.Close();
            }   
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
        }
        #endregion

        #region Form Controls
        private void ConfirmInput_Click(object sender, EventArgs e)
        {
            API.StreamWriter(UsernameInput.Text+",1", @"C:\Users\" + Environment.UserName + @"\AppData\Local\RsThing\Data.txt");
            RuneHelper.MainForm Mainform = new RuneHelper.MainForm();
            Mainform.Show();
            this.Close();
        }
        #endregion
    }
}
