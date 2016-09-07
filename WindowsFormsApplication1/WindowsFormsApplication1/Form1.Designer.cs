namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AttackBar = new System.Windows.Forms.ProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Settings = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DefenceBar = new System.Windows.Forms.ProgressBar();
            this.StrengthBar = new System.Windows.Forms.ProgressBar();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.RangedBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrayerBar = new System.Windows.Forms.ProgressBar();
            this.MagicBar = new System.Windows.Forms.ProgressBar();
            this.WoodcuttingBar = new System.Windows.Forms.ProgressBar();
            this.MiningBar = new System.Windows.Forms.ProgressBar();
            this.SmithingBar = new System.Windows.Forms.ProgressBar();
            this.CraftingBar = new System.Windows.Forms.ProgressBar();
            this.FiremakingBar = new System.Windows.Forms.ProgressBar();
            this.FishingBar = new System.Windows.Forms.ProgressBar();
            this.FletchingBar = new System.Windows.Forms.ProgressBar();
            this.SlayerBar = new System.Windows.Forms.ProgressBar();
            this.ThievingBar = new System.Windows.Forms.ProgressBar();
            this.AgilityBar = new System.Windows.Forms.ProgressBar();
            this.HerbloreBar = new System.Windows.Forms.ProgressBar();
            this.ConstructionBar = new System.Windows.Forms.ProgressBar();
            this.HunterBar = new System.Windows.Forms.ProgressBar();
            this.RunecraftingBar = new System.Windows.Forms.ProgressBar();
            this.FarmingBar = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DungeoneeringBar = new System.Windows.Forms.ProgressBar();
            this.SummoningBar = new System.Windows.Forms.ProgressBar();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PUT STUFF HERE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AttackBar
            // 
            this.AttackBar.Location = new System.Drawing.Point(56, 175);
            this.AttackBar.Maximum = 99;
            this.AttackBar.Name = "AttackBar";
            this.AttackBar.Size = new System.Drawing.Size(135, 23);
            this.AttackBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.AttackBar.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(801, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Settings
            // 
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(69, 22);
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(12, 210);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(0, 20);
            this.UsernameLabel.TabIndex = 5;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Location = new System.Drawing.Point(13, 29);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(103, 116);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ProfilePicture.TabIndex = 6;
            this.ProfilePicture.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(721, 503);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DefenceBar
            // 
            this.DefenceBar.Location = new System.Drawing.Point(56, 223);
            this.DefenceBar.Maximum = 99;
            this.DefenceBar.Name = "DefenceBar";
            this.DefenceBar.Size = new System.Drawing.Size(135, 23);
            this.DefenceBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DefenceBar.TabIndex = 8;
            // 
            // StrengthBar
            // 
            this.StrengthBar.Location = new System.Drawing.Point(56, 276);
            this.StrengthBar.Maximum = 99;
            this.StrengthBar.Name = "StrengthBar";
            this.StrengthBar.Size = new System.Drawing.Size(135, 23);
            this.StrengthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.StrengthBar.TabIndex = 9;
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(56, 318);
            this.HealthBar.Maximum = 99;
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(135, 23);
            this.HealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HealthBar.TabIndex = 10;
            // 
            // RangedBar
            // 
            this.RangedBar.Location = new System.Drawing.Point(56, 369);
            this.RangedBar.Maximum = 99;
            this.RangedBar.Name = "RangedBar";
            this.RangedBar.Size = new System.Drawing.Size(135, 23);
            this.RangedBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RangedBar.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // PrayerBar
            // 
            this.PrayerBar.Location = new System.Drawing.Point(56, 410);
            this.PrayerBar.Maximum = 99;
            this.PrayerBar.Name = "PrayerBar";
            this.PrayerBar.Size = new System.Drawing.Size(135, 23);
            this.PrayerBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PrayerBar.TabIndex = 13;
            // 
            // MagicBar
            // 
            this.MagicBar.Location = new System.Drawing.Point(56, 458);
            this.MagicBar.Maximum = 99;
            this.MagicBar.Name = "MagicBar";
            this.MagicBar.Size = new System.Drawing.Size(135, 23);
            this.MagicBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MagicBar.TabIndex = 14;
            // 
            // WoodcuttingBar
            // 
            this.WoodcuttingBar.Location = new System.Drawing.Point(227, 175);
            this.WoodcuttingBar.Maximum = 99;
            this.WoodcuttingBar.Name = "WoodcuttingBar";
            this.WoodcuttingBar.Size = new System.Drawing.Size(135, 23);
            this.WoodcuttingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.WoodcuttingBar.TabIndex = 15;
            // 
            // MiningBar
            // 
            this.MiningBar.Location = new System.Drawing.Point(227, 458);
            this.MiningBar.Maximum = 99;
            this.MiningBar.Name = "MiningBar";
            this.MiningBar.Size = new System.Drawing.Size(135, 23);
            this.MiningBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MiningBar.TabIndex = 21;
            // 
            // SmithingBar
            // 
            this.SmithingBar.Location = new System.Drawing.Point(227, 410);
            this.SmithingBar.Maximum = 99;
            this.SmithingBar.Name = "SmithingBar";
            this.SmithingBar.Size = new System.Drawing.Size(135, 23);
            this.SmithingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SmithingBar.TabIndex = 20;
            // 
            // CraftingBar
            // 
            this.CraftingBar.Location = new System.Drawing.Point(227, 369);
            this.CraftingBar.Maximum = 99;
            this.CraftingBar.Name = "CraftingBar";
            this.CraftingBar.Size = new System.Drawing.Size(135, 23);
            this.CraftingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CraftingBar.TabIndex = 19;
            // 
            // FiremakingBar
            // 
            this.FiremakingBar.Location = new System.Drawing.Point(227, 318);
            this.FiremakingBar.Maximum = 99;
            this.FiremakingBar.Name = "FiremakingBar";
            this.FiremakingBar.Size = new System.Drawing.Size(135, 23);
            this.FiremakingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FiremakingBar.TabIndex = 18;
            // 
            // FishingBar
            // 
            this.FishingBar.Location = new System.Drawing.Point(227, 276);
            this.FishingBar.Maximum = 99;
            this.FishingBar.Name = "FishingBar";
            this.FishingBar.Size = new System.Drawing.Size(135, 23);
            this.FishingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FishingBar.TabIndex = 17;
            // 
            // FletchingBar
            // 
            this.FletchingBar.Location = new System.Drawing.Point(227, 223);
            this.FletchingBar.Maximum = 99;
            this.FletchingBar.Name = "FletchingBar";
            this.FletchingBar.Size = new System.Drawing.Size(135, 23);
            this.FletchingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FletchingBar.TabIndex = 16;
            // 
            // SlayerBar
            // 
            this.SlayerBar.Location = new System.Drawing.Point(385, 318);
            this.SlayerBar.Maximum = 99;
            this.SlayerBar.Name = "SlayerBar";
            this.SlayerBar.Size = new System.Drawing.Size(135, 23);
            this.SlayerBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SlayerBar.TabIndex = 25;
            // 
            // ThievingBar
            // 
            this.ThievingBar.Location = new System.Drawing.Point(385, 276);
            this.ThievingBar.Maximum = 99;
            this.ThievingBar.Name = "ThievingBar";
            this.ThievingBar.Size = new System.Drawing.Size(135, 23);
            this.ThievingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ThievingBar.TabIndex = 24;
            // 
            // AgilityBar
            // 
            this.AgilityBar.Location = new System.Drawing.Point(385, 223);
            this.AgilityBar.Maximum = 99;
            this.AgilityBar.Name = "AgilityBar";
            this.AgilityBar.Size = new System.Drawing.Size(135, 23);
            this.AgilityBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.AgilityBar.TabIndex = 23;
            // 
            // HerbloreBar
            // 
            this.HerbloreBar.Location = new System.Drawing.Point(385, 175);
            this.HerbloreBar.Maximum = 99;
            this.HerbloreBar.Name = "HerbloreBar";
            this.HerbloreBar.Size = new System.Drawing.Size(135, 23);
            this.HerbloreBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HerbloreBar.TabIndex = 22;
            // 
            // ConstructionBar
            // 
            this.ConstructionBar.Location = new System.Drawing.Point(554, 175);
            this.ConstructionBar.Maximum = 99;
            this.ConstructionBar.Name = "ConstructionBar";
            this.ConstructionBar.Size = new System.Drawing.Size(135, 23);
            this.ConstructionBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ConstructionBar.TabIndex = 29;
            // 
            // HunterBar
            // 
            this.HunterBar.Location = new System.Drawing.Point(385, 452);
            this.HunterBar.Maximum = 99;
            this.HunterBar.Name = "HunterBar";
            this.HunterBar.Size = new System.Drawing.Size(135, 23);
            this.HunterBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HunterBar.TabIndex = 28;
            // 
            // RunecraftingBar
            // 
            this.RunecraftingBar.Location = new System.Drawing.Point(385, 399);
            this.RunecraftingBar.Maximum = 99;
            this.RunecraftingBar.Name = "RunecraftingBar";
            this.RunecraftingBar.Size = new System.Drawing.Size(135, 23);
            this.RunecraftingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RunecraftingBar.TabIndex = 27;
            // 
            // FarmingBar
            // 
            this.FarmingBar.Location = new System.Drawing.Point(385, 351);
            this.FarmingBar.Maximum = 99;
            this.FarmingBar.Name = "FarmingBar";
            this.FarmingBar.Size = new System.Drawing.Size(135, 23);
            this.FarmingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FarmingBar.TabIndex = 26;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(554, 319);
            this.progressBar1.Maximum = 99;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(135, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 32;
            // 
            // DungeoneeringBar
            // 
            this.DungeoneeringBar.Location = new System.Drawing.Point(554, 266);
            this.DungeoneeringBar.Maximum = 99;
            this.DungeoneeringBar.Name = "DungeoneeringBar";
            this.DungeoneeringBar.Size = new System.Drawing.Size(135, 23);
            this.DungeoneeringBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DungeoneeringBar.TabIndex = 31;
            // 
            // SummoningBar
            // 
            this.SummoningBar.Location = new System.Drawing.Point(554, 218);
            this.SummoningBar.Maximum = 99;
            this.SummoningBar.Name = "SummoningBar";
            this.SummoningBar.Size = new System.Drawing.Size(135, 23);
            this.SummoningBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SummoningBar.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 529);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DungeoneeringBar);
            this.Controls.Add(this.SummoningBar);
            this.Controls.Add(this.ConstructionBar);
            this.Controls.Add(this.HunterBar);
            this.Controls.Add(this.RunecraftingBar);
            this.Controls.Add(this.FarmingBar);
            this.Controls.Add(this.SlayerBar);
            this.Controls.Add(this.ThievingBar);
            this.Controls.Add(this.AgilityBar);
            this.Controls.Add(this.HerbloreBar);
            this.Controls.Add(this.MiningBar);
            this.Controls.Add(this.SmithingBar);
            this.Controls.Add(this.CraftingBar);
            this.Controls.Add(this.FiremakingBar);
            this.Controls.Add(this.FishingBar);
            this.Controls.Add(this.FletchingBar);
            this.Controls.Add(this.WoodcuttingBar);
            this.Controls.Add(this.MagicBar);
            this.Controls.Add(this.PrayerBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RangedBar);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.StrengthBar);
            this.Controls.Add(this.DefenceBar);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.AttackBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar AttackBar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Settings;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ProgressBar DefenceBar;
        private System.Windows.Forms.ProgressBar StrengthBar;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.ProgressBar RangedBar;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar PrayerBar;
        private System.Windows.Forms.ProgressBar MagicBar;
        private System.Windows.Forms.ProgressBar WoodcuttingBar;
        private System.Windows.Forms.ProgressBar MiningBar;
        private System.Windows.Forms.ProgressBar SmithingBar;
        private System.Windows.Forms.ProgressBar CraftingBar;
        private System.Windows.Forms.ProgressBar FiremakingBar;
        private System.Windows.Forms.ProgressBar FishingBar;
        private System.Windows.Forms.ProgressBar FletchingBar;
        private System.Windows.Forms.ProgressBar SlayerBar;
        private System.Windows.Forms.ProgressBar ThievingBar;
        private System.Windows.Forms.ProgressBar AgilityBar;
        private System.Windows.Forms.ProgressBar HerbloreBar;
        private System.Windows.Forms.ProgressBar ConstructionBar;
        private System.Windows.Forms.ProgressBar HunterBar;
        private System.Windows.Forms.ProgressBar RunecraftingBar;
        private System.Windows.Forms.ProgressBar FarmingBar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar DungeoneeringBar;
        private System.Windows.Forms.ProgressBar SummoningBar;
    }
}

