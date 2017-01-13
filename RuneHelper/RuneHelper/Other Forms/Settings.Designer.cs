namespace RuneHelper
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.UsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.DeleteXP = new MetroFramework.Controls.MetroButton();
            this.DeleteImage = new MetroFramework.Controls.MetroButton();
            this.Light = new MetroFramework.Controls.MetroTile();
            this.Dark = new MetroFramework.Controls.MetroTile();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Red = new MetroFramework.Controls.MetroTile();
            this.Blue = new MetroFramework.Controls.MetroTile();
            this.Green = new MetroFramework.Controls.MetroTile();
            this.Orange = new MetroFramework.Controls.MetroTile();
            this.ColourLabel = new MetroFramework.Controls.MetroLabel();
            this.Pink = new MetroFramework.Controls.MetroTile();
            this.Silver = new MetroFramework.Controls.MetroTile();
            this.Purple = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(23, 219);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(113, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Save And Exit";
            this.Exit.UseSelectable = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UsernameTextBox
            // 
            // 
            // 
            // 
            this.UsernameTextBox.CustomButton.Image = null;
            this.UsernameTextBox.CustomButton.Location = new System.Drawing.Point(167, 2);
            this.UsernameTextBox.CustomButton.Name = "";
            this.UsernameTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.UsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameTextBox.CustomButton.TabIndex = 1;
            this.UsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameTextBox.CustomButton.UseSelectable = true;
            this.UsernameTextBox.CustomButton.Visible = false;
            this.UsernameTextBox.Lines = new string[0];
            this.UsernameTextBox.Location = new System.Drawing.Point(23, 86);
            this.UsernameTextBox.MaxLength = 32767;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PasswordChar = '\0';
            this.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTextBox.SelectedText = "";
            this.UsernameTextBox.SelectionLength = 0;
            this.UsernameTextBox.SelectionStart = 0;
            this.UsernameTextBox.ShortcutsEnabled = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(185, 20);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.UseSelectable = true;
            this.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // DeleteXP
            // 
            this.DeleteXP.Location = new System.Drawing.Point(23, 141);
            this.DeleteXP.Name = "DeleteXP";
            this.DeleteXP.Size = new System.Drawing.Size(117, 23);
            this.DeleteXP.TabIndex = 3;
            this.DeleteXP.Text = "Delete saved XP";
            this.DeleteXP.UseSelectable = true;
            this.DeleteXP.Click += new System.EventHandler(this.DeleteXP_Click);
            // 
            // DeleteImage
            // 
            this.DeleteImage.Location = new System.Drawing.Point(23, 112);
            this.DeleteImage.Name = "DeleteImage";
            this.DeleteImage.Size = new System.Drawing.Size(158, 23);
            this.DeleteImage.TabIndex = 4;
            this.DeleteImage.Text = "Delete Cached Profile Image";
            this.DeleteImage.UseSelectable = true;
            this.DeleteImage.Click += new System.EventHandler(this.DeleteImage_Click);
            // 
            // Light
            // 
            this.Light.ActiveControl = null;
            this.Light.Location = new System.Drawing.Point(342, 116);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(101, 60);
            this.Light.Style = MetroFramework.MetroColorStyle.Silver;
            this.Light.TabIndex = 5;
            this.Light.Text = "Light Theme";
            this.Light.UseSelectable = true;
            this.Light.Click += new System.EventHandler(this.Light_Click);
            // 
            // Dark
            // 
            this.Dark.ActiveControl = null;
            this.Dark.Location = new System.Drawing.Point(342, 182);
            this.Dark.Name = "Dark";
            this.Dark.Size = new System.Drawing.Size(101, 60);
            this.Dark.Style = MetroFramework.MetroColorStyle.Black;
            this.Dark.TabIndex = 6;
            this.Dark.Text = "Dark Theme";
            this.Dark.UseSelectable = true;
            this.Dark.Click += new System.EventHandler(this.Dark_Click);
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            // 
            // Red
            // 
            this.Red.ActiveControl = null;
            this.Red.Location = new System.Drawing.Point(341, 89);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(21, 23);
            this.Red.Style = MetroFramework.MetroColorStyle.Red;
            this.Red.TabIndex = 7;
            this.Red.UseSelectable = true;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Blue
            // 
            this.Blue.ActiveControl = null;
            this.Blue.Location = new System.Drawing.Point(368, 89);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(21, 23);
            this.Blue.Style = MetroFramework.MetroColorStyle.Blue;
            this.Blue.TabIndex = 9;
            this.Blue.UseSelectable = true;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Green
            // 
            this.Green.ActiveControl = null;
            this.Green.Location = new System.Drawing.Point(395, 89);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(21, 23);
            this.Green.Style = MetroFramework.MetroColorStyle.Green;
            this.Green.TabIndex = 10;
            this.Green.UseSelectable = true;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Orange
            // 
            this.Orange.ActiveControl = null;
            this.Orange.Location = new System.Drawing.Point(421, 89);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(21, 23);
            this.Orange.Style = MetroFramework.MetroColorStyle.Orange;
            this.Orange.TabIndex = 11;
            this.Orange.UseSelectable = true;
            this.Orange.Click += new System.EventHandler(this.Orange_Click);
            // 
            // ColourLabel
            // 
            this.ColourLabel.AutoSize = true;
            this.ColourLabel.Location = new System.Drawing.Point(312, 21);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(131, 19);
            this.ColourLabel.TabIndex = 12;
            this.ColourLabel.Text = "Themes And Colours";
            // 
            // Pink
            // 
            this.Pink.ActiveControl = null;
            this.Pink.Location = new System.Drawing.Point(369, 60);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(21, 23);
            this.Pink.Style = MetroFramework.MetroColorStyle.Pink;
            this.Pink.TabIndex = 13;
            this.Pink.UseSelectable = true;
            this.Pink.Click += new System.EventHandler(this.Pink_Click);
            // 
            // Silver
            // 
            this.Silver.ActiveControl = null;
            this.Silver.Location = new System.Drawing.Point(341, 60);
            this.Silver.Name = "Silver";
            this.Silver.Size = new System.Drawing.Size(21, 23);
            this.Silver.Style = MetroFramework.MetroColorStyle.Silver;
            this.Silver.TabIndex = 14;
            this.Silver.UseSelectable = true;
            this.Silver.Click += new System.EventHandler(this.Silver_Click);
            // 
            // Purple
            // 
            this.Purple.ActiveControl = null;
            this.Purple.Location = new System.Drawing.Point(396, 60);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(20, 23);
            this.Purple.Style = MetroFramework.MetroColorStyle.Purple;
            this.Purple.TabIndex = 15;
            this.Purple.UseSelectable = true;
            this.Purple.Click += new System.EventHandler(this.Purple_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(421, 60);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(21, 23);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTile1.TabIndex = 16;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // SettingsForm
            // 
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(448, 254);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.Purple);
            this.Controls.Add(this.Silver);
            this.Controls.Add(this.Pink);
            this.Controls.Add(this.ColourLabel);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Dark);
            this.Controls.Add(this.Light);
            this.Controls.Add(this.DeleteImage);
            this.Controls.Add(this.DeleteXP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Exit;
        private MetroFramework.Controls.MetroTextBox UsernameTextBox;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroButton DeleteXP;
        private MetroFramework.Controls.MetroButton DeleteImage;
        private MetroFramework.Controls.MetroTile Light;
        private MetroFramework.Controls.MetroTile Dark;
        private new MetroFramework.Components.MetroStyleManager StyleManager;
        private MetroFramework.Controls.MetroTile Red;
        private MetroFramework.Controls.MetroTile Orange;
        private MetroFramework.Controls.MetroTile Green;
        private MetroFramework.Controls.MetroTile Blue;
        private MetroFramework.Controls.MetroLabel ColourLabel;
        private MetroFramework.Controls.MetroTile Pink;
        private MetroFramework.Controls.MetroTile Silver;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile Purple;
    }
}