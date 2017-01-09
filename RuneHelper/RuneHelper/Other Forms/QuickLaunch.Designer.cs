namespace RuneHelper
{
    partial class QuickLaunch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickLaunch));
            this.Launch = new MetroFramework.Controls.MetroButton();
            this.Input = new MetroFramework.Controls.MetroTextBox();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // Launch
            // 
            this.Launch.Location = new System.Drawing.Point(23, 92);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(100, 23);
            this.Launch.TabIndex = 0;
            this.Launch.Text = "Launch";
            this.Launch.UseSelectable = true;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // Input
            // 
            // 
            // 
            // 
            this.Input.CustomButton.Image = null;
            this.Input.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.Input.CustomButton.Name = "";
            this.Input.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Input.CustomButton.TabIndex = 1;
            this.Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Input.CustomButton.UseSelectable = true;
            this.Input.CustomButton.Visible = false;
            this.Input.Lines = new string[0];
            this.Input.Location = new System.Drawing.Point(23, 63);
            this.Input.MaxLength = 32767;
            this.Input.Name = "Input";
            this.Input.PasswordChar = '\0';
            this.Input.PromptText = "Wiki item name";
            this.Input.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Input.SelectedText = "";
            this.Input.SelectionLength = 0;
            this.Input.SelectionStart = 0;
            this.Input.ShortcutsEnabled = true;
            this.Input.Size = new System.Drawing.Size(258, 23);
            this.Input.TabIndex = 1;
            this.Input.UseSelectable = true;
            this.Input.WaterMark = "Wiki item name";
            this.Input.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Input.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            // 
            // QuickLaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 150);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Launch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuickLaunch";
            this.Resizable = false;
            this.StyleManager = this.StyleManager;
            this.Text = "Search wiki";
            this.Load += new System.EventHandler(this.QuickLaunch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Launch;
        private MetroFramework.Controls.MetroTextBox Input;
        private MetroFramework.Components.MetroStyleManager StyleManager;
    }
}