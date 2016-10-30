﻿namespace RuneHelper
{
    partial class WooducttingCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WooducttingCalculator));
            this.CachedName = new MetroFramework.Controls.MetroButton();
            this.CharSearchButton = new MetroFramework.Controls.MetroButton();
            this.CharNameBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.XPBox = new System.Windows.Forms.TextBox();
            this.TargetLevelLabel = new MetroFramework.Controls.MetroLabel();
            this.BonusXPlabel = new MetroFramework.Controls.MetroLabel();
            this.TargetBox = new MetroFramework.Controls.MetroTextBox();
            this.BonusBox = new MetroFramework.Controls.MetroTextBox();
            this.CalculateBtn = new MetroFramework.Controls.MetroButton();
            this.TreeTypeBox = new MetroFramework.Controls.MetroComboBox();
            this.AmountBox = new MetroFramework.Controls.MetroTextBox();
            this.BackBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CachedName
            // 
            this.CachedName.Location = new System.Drawing.Point(238, 64);
            this.CachedName.Name = "CachedName";
            this.CachedName.Size = new System.Drawing.Size(107, 23);
            this.CachedName.TabIndex = 13;
            this.CachedName.Text = "Use Saved Name";
            this.CachedName.UseSelectable = true;
            this.CachedName.Click += new System.EventHandler(this.CachedName_Click);
            // 
            // CharSearchButton
            // 
            this.CharSearchButton.Location = new System.Drawing.Point(157, 63);
            this.CharSearchButton.Name = "CharSearchButton";
            this.CharSearchButton.Size = new System.Drawing.Size(75, 23);
            this.CharSearchButton.TabIndex = 12;
            this.CharSearchButton.Text = "Search";
            this.CharSearchButton.UseSelectable = true;
            this.CharSearchButton.Click += new System.EventHandler(this.CharSearchButton_Click);
            // 
            // CharNameBox
            // 
            // 
            // 
            // 
            this.CharNameBox.CustomButton.Image = null;
            this.CharNameBox.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.CharNameBox.CustomButton.Name = "";
            this.CharNameBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.CharNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CharNameBox.CustomButton.TabIndex = 1;
            this.CharNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CharNameBox.CustomButton.UseSelectable = true;
            this.CharNameBox.CustomButton.Visible = false;
            this.CharNameBox.Lines = new string[] {
        "Enter Character Name Here"};
            this.CharNameBox.Location = new System.Drawing.Point(11, 66);
            this.CharNameBox.MaxLength = 32767;
            this.CharNameBox.Name = "CharNameBox";
            this.CharNameBox.PasswordChar = '\0';
            this.CharNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CharNameBox.SelectedText = "";
            this.CharNameBox.SelectionLength = 0;
            this.CharNameBox.SelectionStart = 0;
            this.CharNameBox.ShortcutsEnabled = true;
            this.CharNameBox.Size = new System.Drawing.Size(140, 20);
            this.CharNameBox.TabIndex = 11;
            this.CharNameBox.Text = "Enter Character Name Here";
            this.CharNameBox.UseSelectable = true;
            this.CharNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CharNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Woodcutting XP";
            // 
            // XPBox
            // 
            this.XPBox.Location = new System.Drawing.Point(118, 114);
            this.XPBox.Name = "XPBox";
            this.XPBox.Size = new System.Drawing.Size(194, 20);
            this.XPBox.TabIndex = 15;
            // 
            // TargetLevelLabel
            // 
            this.TargetLevelLabel.AutoSize = true;
            this.TargetLevelLabel.Location = new System.Drawing.Point(8, 152);
            this.TargetLevelLabel.Name = "TargetLevelLabel";
            this.TargetLevelLabel.Size = new System.Drawing.Size(114, 19);
            this.TargetLevelLabel.TabIndex = 16;
            this.TargetLevelLabel.Text = "Enter Target Level";
            this.TargetLevelLabel.Visible = false;
            // 
            // BonusXPlabel
            // 
            this.BonusXPlabel.AutoSize = true;
            this.BonusXPlabel.Location = new System.Drawing.Point(11, 185);
            this.BonusXPlabel.Name = "BonusXPlabel";
            this.BonusXPlabel.Size = new System.Drawing.Size(98, 19);
            this.BonusXPlabel.TabIndex = 17;
            this.BonusXPlabel.Text = "Enter Bonus XP";
            this.BonusXPlabel.Visible = false;
            // 
            // TargetBox
            // 
            // 
            // 
            // 
            this.TargetBox.CustomButton.Image = null;
            this.TargetBox.CustomButton.Location = new System.Drawing.Point(139, 2);
            this.TargetBox.CustomButton.Name = "";
            this.TargetBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TargetBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TargetBox.CustomButton.TabIndex = 1;
            this.TargetBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TargetBox.CustomButton.UseSelectable = true;
            this.TargetBox.CustomButton.Visible = false;
            this.TargetBox.Lines = new string[0];
            this.TargetBox.Location = new System.Drawing.Point(155, 152);
            this.TargetBox.MaxLength = 2;
            this.TargetBox.Name = "TargetBox";
            this.TargetBox.PasswordChar = '\0';
            this.TargetBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TargetBox.SelectedText = "";
            this.TargetBox.SelectionLength = 0;
            this.TargetBox.SelectionStart = 0;
            this.TargetBox.ShortcutsEnabled = true;
            this.TargetBox.Size = new System.Drawing.Size(157, 20);
            this.TargetBox.TabIndex = 18;
            this.TargetBox.UseSelectable = true;
            this.TargetBox.Visible = false;
            this.TargetBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TargetBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BonusBox
            // 
            // 
            // 
            // 
            this.BonusBox.CustomButton.Image = null;
            this.BonusBox.CustomButton.Location = new System.Drawing.Point(139, 2);
            this.BonusBox.CustomButton.Name = "";
            this.BonusBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.BonusBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BonusBox.CustomButton.TabIndex = 1;
            this.BonusBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BonusBox.CustomButton.UseSelectable = true;
            this.BonusBox.CustomButton.Visible = false;
            this.BonusBox.Lines = new string[0];
            this.BonusBox.Location = new System.Drawing.Point(155, 185);
            this.BonusBox.MaxLength = 32767;
            this.BonusBox.Name = "BonusBox";
            this.BonusBox.PasswordChar = '\0';
            this.BonusBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BonusBox.SelectedText = "";
            this.BonusBox.SelectionLength = 0;
            this.BonusBox.SelectionStart = 0;
            this.BonusBox.ShortcutsEnabled = true;
            this.BonusBox.Size = new System.Drawing.Size(157, 20);
            this.BonusBox.TabIndex = 19;
            this.BonusBox.UseSelectable = true;
            this.BonusBox.Visible = false;
            this.BonusBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BonusBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(143, 333);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 20;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseSelectable = true;
            this.CalculateBtn.Visible = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // TreeTypeBox
            // 
            this.TreeTypeBox.FormattingEnabled = true;
            this.TreeTypeBox.IntegralHeight = false;
            this.TreeTypeBox.ItemHeight = 23;
            this.TreeTypeBox.Items.AddRange(new object[] {
            "Tree",
            "Oak",
            "Willow",
            "Teak",
            "Maple",
            "Hollow wood",
            "Hollow bark",
            "Mahoghany",
            "Artic pine",
            "Eucalyptus",
            "Ivy",
            "Yew",
            "Magic",
            "Cursed magic tree",
            "bloodwood",
            "Elder tree",
            "Bamboo",
            "Crystal tree",
            "Golden bamboo"});
            this.TreeTypeBox.Location = new System.Drawing.Point(11, 222);
            this.TreeTypeBox.Name = "TreeTypeBox";
            this.TreeTypeBox.Size = new System.Drawing.Size(157, 29);
            this.TreeTypeBox.TabIndex = 21;
            this.TreeTypeBox.UseSelectable = true;
            this.TreeTypeBox.Visible = false;
            // 
            // AmountBox
            // 
            // 
            // 
            // 
            this.AmountBox.CustomButton.Image = null;
            this.AmountBox.CustomButton.Location = new System.Drawing.Point(139, 2);
            this.AmountBox.CustomButton.Name = "";
            this.AmountBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.AmountBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AmountBox.CustomButton.TabIndex = 1;
            this.AmountBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AmountBox.CustomButton.UseSelectable = true;
            this.AmountBox.CustomButton.Visible = false;
            this.AmountBox.Lines = new string[0];
            this.AmountBox.Location = new System.Drawing.Point(75, 373);
            this.AmountBox.MaxLength = 32767;
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.PasswordChar = '\0';
            this.AmountBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AmountBox.SelectedText = "";
            this.AmountBox.SelectionLength = 0;
            this.AmountBox.SelectionStart = 0;
            this.AmountBox.ShortcutsEnabled = true;
            this.AmountBox.Size = new System.Drawing.Size(157, 20);
            this.AmountBox.TabIndex = 22;
            this.AmountBox.UseSelectable = true;
            this.AmountBox.Visible = false;
            this.AmountBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AmountBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(143, 410);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 23;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseSelectable = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // WooducttingCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 459);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.TreeTypeBox);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.BonusBox);
            this.Controls.Add(this.TargetBox);
            this.Controls.Add(this.BonusXPlabel);
            this.Controls.Add(this.TargetLevelLabel);
            this.Controls.Add(this.XPBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CachedName);
            this.Controls.Add(this.CharSearchButton);
            this.Controls.Add(this.CharNameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WooducttingCalculator";
            this.Text = "WoodCutting Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CachedName;
        private MetroFramework.Controls.MetroButton CharSearchButton;
        private MetroFramework.Controls.MetroTextBox CharNameBox;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel TargetLevelLabel;
        private MetroFramework.Controls.MetroLabel BonusXPlabel;
        private MetroFramework.Controls.MetroTextBox TargetBox;
        private MetroFramework.Controls.MetroTextBox BonusBox;
        private MetroFramework.Controls.MetroButton CalculateBtn;
        private MetroFramework.Controls.MetroComboBox TreeTypeBox;
        private MetroFramework.Controls.MetroTextBox AmountBox;
        private MetroFramework.Controls.MetroButton BackBtn;
        private System.Windows.Forms.TextBox XPBox;
    }
}