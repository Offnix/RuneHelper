namespace RsThing
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.CachedName = new System.Windows.Forms.Button();
            this.CharSearchButton = new System.Windows.Forms.Button();
            this.CharNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.XPBox = new System.Windows.Forms.TextBox();
            this.TargetLevelLabel = new System.Windows.Forms.Label();
            this.BonusXPlabel = new System.Windows.Forms.Label();
            this.TargetBox = new System.Windows.Forms.TextBox();
            this.BonusBox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.TypeBox = new System.Windows.Forms.CheckedListBox();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CachedName
            // 
            this.CachedName.Location = new System.Drawing.Point(238, 37);
            this.CachedName.Name = "CachedName";
            this.CachedName.Size = new System.Drawing.Size(107, 23);
            this.CachedName.TabIndex = 13;
            this.CachedName.Text = "Use Saved Name";
            this.CachedName.UseVisualStyleBackColor = true;
            this.CachedName.Click += new System.EventHandler(this.CachedName_Click);
            // 
            // CharSearchButton
            // 
            this.CharSearchButton.Location = new System.Drawing.Point(157, 36);
            this.CharSearchButton.Name = "CharSearchButton";
            this.CharSearchButton.Size = new System.Drawing.Size(75, 23);
            this.CharSearchButton.TabIndex = 12;
            this.CharSearchButton.Text = "Search";
            this.CharSearchButton.UseVisualStyleBackColor = true;
            this.CharSearchButton.Click += new System.EventHandler(this.CharSearchButton_Click);
            // 
            // CharNameBox
            // 
            this.CharNameBox.Location = new System.Drawing.Point(11, 39);
            this.CharNameBox.Name = "CharNameBox";
            this.CharNameBox.Size = new System.Drawing.Size(140, 20);
            this.CharNameBox.TabIndex = 11;
            this.CharNameBox.Text = "Enter Character Name Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mining XP";
            // 
            // XPBox
            // 
            this.XPBox.Location = new System.Drawing.Point(118, 87);
            this.XPBox.Name = "XPBox";
            this.XPBox.Size = new System.Drawing.Size(194, 20);
            this.XPBox.TabIndex = 15;
            // 
            // TargetLevelLabel
            // 
            this.TargetLevelLabel.AutoSize = true;
            this.TargetLevelLabel.Location = new System.Drawing.Point(8, 125);
            this.TargetLevelLabel.Name = "TargetLevelLabel";
            this.TargetLevelLabel.Size = new System.Drawing.Size(95, 13);
            this.TargetLevelLabel.TabIndex = 16;
            this.TargetLevelLabel.Text = "Enter Target Level";
            this.TargetLevelLabel.Visible = false;
            // 
            // BonusXPlabel
            // 
            this.BonusXPlabel.AutoSize = true;
            this.BonusXPlabel.Location = new System.Drawing.Point(11, 158);
            this.BonusXPlabel.Name = "BonusXPlabel";
            this.BonusXPlabel.Size = new System.Drawing.Size(82, 13);
            this.BonusXPlabel.TabIndex = 17;
            this.BonusXPlabel.Text = "Enter Bonus XP";
            this.BonusXPlabel.Visible = false;
            // 
            // TargetBox
            // 
            this.TargetBox.Location = new System.Drawing.Point(155, 125);
            this.TargetBox.MaxLength = 2;
            this.TargetBox.Name = "TargetBox";
            this.TargetBox.Size = new System.Drawing.Size(157, 20);
            this.TargetBox.TabIndex = 18;
            this.TargetBox.Visible = false;
            // 
            // BonusBox
            // 
            this.BonusBox.Location = new System.Drawing.Point(155, 158);
            this.BonusBox.Name = "BonusBox";
            this.BonusBox.Size = new System.Drawing.Size(157, 20);
            this.BonusBox.TabIndex = 19;
            this.BonusBox.Visible = false;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(143, 306);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 20;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Visible = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.IntegralHeight = false;
            this.TypeBox.Items.AddRange(new object[] {
            "Clay / Rune essence / Pure essence",
            "Copper/ Tin / Blurlite / Daeyalt / Rubium",
            "Living minerals",
            "Limestone",
            "Iron",
            "Silver",
            "Coal",
            "Sandstone",
            "Gem Rock",
            "Gold",
            "Granite",
            "Mithril",
            "Adamantite",
            "Bane ore",
            "Concentrated coal rocks",
            "Concentrated gold rocks",
            "Red sandstone",
            "Runite",
            "Seren Stones",
            "Salty crablet",
            "Alaea crablet",
            "Idol crablet\t"});
            this.TypeBox.Location = new System.Drawing.Point(11, 195);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(157, 94);
            this.TypeBox.TabIndex = 21;
            this.TypeBox.Visible = false;
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(105, 345);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(157, 20);
            this.AmountBox.TabIndex = 22;
            this.AmountBox.Visible = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(143, 383);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 23;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 418);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Mining Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CachedName;
        private System.Windows.Forms.Button CharSearchButton;
        private System.Windows.Forms.TextBox CharNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox XPBox;
        private System.Windows.Forms.Label TargetLevelLabel;
        private System.Windows.Forms.Label BonusXPlabel;
        private System.Windows.Forms.TextBox TargetBox;
        private System.Windows.Forms.TextBox BonusBox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.CheckedListBox TypeBox;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Button BackBtn;
    }
}