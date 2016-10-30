namespace RuneHelper
{
    partial class AgilityCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgilityCalc));
            this.CachedName = new MetroFramework.Controls.MetroButton();
            this.CharSearchButton = new MetroFramework.Controls.MetroButton();
            this.CharNameBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.XPBox = new MetroFramework.Controls.MetroTextBox();
            this.TargetLevelLabel = new MetroFramework.Controls.MetroLabel();
            this.BonusXPlabel = new MetroFramework.Controls.MetroLabel();
            this.TargetBox = new MetroFramework.Controls.MetroTextBox();
            this.BonusBox = new MetroFramework.Controls.MetroTextBox();
            this.CalculateBtn = new MetroFramework.Controls.MetroButton();
            this.TypeBox = new MetroFramework.Controls.MetroComboBox();
            this.AmountBox = new MetroFramework.Controls.MetroTextBox();
            this.BackBtn = new MetroFramework.Controls.MetroButton();
            this.LapsLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // CachedName
            // 
            this.CachedName.Location = new System.Drawing.Point(238, 62);
            this.CachedName.Name = "CachedName";
            this.CachedName.Size = new System.Drawing.Size(107, 23);
            this.CachedName.TabIndex = 13;
            this.CachedName.Text = "Use Saved Name";
            this.CachedName.Click += new System.EventHandler(this.CachedName_Click);
            // 
            // CharSearchButton
            // 
            this.CharSearchButton.Location = new System.Drawing.Point(157, 61);
            this.CharSearchButton.Name = "CharSearchButton";
            this.CharSearchButton.Size = new System.Drawing.Size(75, 23);
            this.CharSearchButton.TabIndex = 12;
            this.CharSearchButton.Text = "Search";
            this.CharSearchButton.Click += new System.EventHandler(this.CharSearchButton_Click);
            // 
            // CharNameBox
            // 
            this.CharNameBox.Location = new System.Drawing.Point(11, 64);
            this.CharNameBox.Name = "CharNameBox";
            this.CharNameBox.Size = new System.Drawing.Size(140, 20);
            this.CharNameBox.TabIndex = 11;
            this.CharNameBox.Text = "Enter Character Name Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Agility XP";
            // 
            // XPBox
            // 
            this.XPBox.Location = new System.Drawing.Point(118, 112);
            this.XPBox.Name = "XPBox";
            this.XPBox.Size = new System.Drawing.Size(194, 20);
            this.XPBox.TabIndex = 15;
            // 
            // TargetLevelLabel
            // 
            this.TargetLevelLabel.AutoSize = true;
            this.TargetLevelLabel.Location = new System.Drawing.Point(8, 150);
            this.TargetLevelLabel.Name = "TargetLevelLabel";
            this.TargetLevelLabel.Size = new System.Drawing.Size(95, 13);
            this.TargetLevelLabel.TabIndex = 16;
            this.TargetLevelLabel.Text = "Enter Target Level";
            this.TargetLevelLabel.Visible = false;
            // 
            // BonusXPlabel
            // 
            this.BonusXPlabel.AutoSize = true;
            this.BonusXPlabel.Location = new System.Drawing.Point(11, 183);
            this.BonusXPlabel.Name = "BonusXPlabel";
            this.BonusXPlabel.Size = new System.Drawing.Size(82, 13);
            this.BonusXPlabel.TabIndex = 17;
            this.BonusXPlabel.Text = "Enter Bonus XP";
            this.BonusXPlabel.Visible = false;
            // 
            // TargetBox
            // 
            this.TargetBox.Location = new System.Drawing.Point(155, 150);
            this.TargetBox.MaxLength = 2;
            this.TargetBox.Name = "TargetBox";
            this.TargetBox.Size = new System.Drawing.Size(157, 20);
            this.TargetBox.TabIndex = 18;
            this.TargetBox.Visible = false;
            // 
            // BonusBox
            // 
            this.BonusBox.Location = new System.Drawing.Point(155, 183);
            this.BonusBox.Name = "BonusBox";
            this.BonusBox.Size = new System.Drawing.Size(157, 20);
            this.BonusBox.TabIndex = 19;
            this.BonusBox.Visible = false;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(143, 331);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 20;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.Visible = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.IntegralHeight = false;
            this.TypeBox.Items.AddRange(new object[] {
            "Burthorpe Agility Course",
            "Gnome Stronghold Agility Course",
            "Werewolf Skullball",
            "Agility Pyramid",
            "Penguin Agility Course",
            "Barbarian Outpost Agility Course",
            "Ape Atoll Agility Course",
            "Wilderness Agility Course",
            "Bandos Agility Course",
            "Werewolf Agility Course",
            "Hefin Agility Course",
            "Dorgesh-Kaan Agility Course",
            "Advanced Gnome Stronghold Agility Course",
            "Advanced Barbarian Outpost Agility Course"});
            this.TypeBox.Location = new System.Drawing.Point(11, 220);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(207, 94);
            this.TypeBox.TabIndex = 21;
            this.TypeBox.Visible = false;
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(75, 373);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(157, 20);
            this.AmountBox.TabIndex = 22;
            this.AmountBox.Visible = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(143, 408);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 23;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LapsLabel
            // 
            this.LapsLabel.AutoSize = true;
            this.LapsLabel.Location = new System.Drawing.Point(238, 376);
            this.LapsLabel.Name = "LapsLabel";
            this.LapsLabel.Size = new System.Drawing.Size(30, 13);
            this.LapsLabel.TabIndex = 24;
            this.LapsLabel.Text = "Laps";
            this.LapsLabel.Visible = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 446);
            this.Controls.Add(this.LapsLabel);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.TypeBox);
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
            this.Name = "Form6";
            this.Resizable = false;
            this.Text = "Agility Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CachedName;
        private MetroFramework.Controls.MetroButton CharSearchButton;
        private MetroFramework.Controls.MetroTextBox CharNameBox;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox XPBox;
        private MetroFramework.Controls.MetroLabel TargetLevelLabel;
        private MetroFramework.Controls.MetroLabel BonusXPlabel;
        private MetroFramework.Controls.MetroTextBox TargetBox;
        private MetroFramework.Controls.MetroTextBox BonusBox;
        private MetroFramework.Controls.MetroButton CalculateBtn;
        private MetroFramework.Controls.MetroComboBox TypeBox;
        private MetroFramework.Controls.MetroTextBox AmountBox;
        private MetroFramework.Controls.MetroButton BackBtn;
        private MetroFramework.Controls.MetroLabel LapsLabel;
    }
}