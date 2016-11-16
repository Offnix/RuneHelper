namespace RuneHelper
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Github = new System.Windows.Forms.PictureBox();
            this.AboutBox = new System.Windows.Forms.RichTextBox();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Github)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // Github
            // 
            this.Github.Image = ((System.Drawing.Image)(resources.GetObject("Github.Image")));
            this.Github.Location = new System.Drawing.Point(-1, 275);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(89, 86);
            this.Github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Github.TabIndex = 0;
            this.Github.TabStop = false;
            this.Github.Click += new System.EventHandler(this.Github_Click);
            // 
            // AboutBox
            // 
            this.AboutBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AboutBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutBox.Location = new System.Drawing.Point(5, 59);
            this.AboutBox.Name = "AboutBox";
            this.AboutBox.ReadOnly = true;
            this.AboutBox.Size = new System.Drawing.Size(311, 216);
            this.AboutBox.TabIndex = 1;
            this.AboutBox.Text = resources.GetString("AboutBox.Text");
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(316, 363);
            this.Controls.Add(this.AboutBox);
            this.Controls.Add(this.Github);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Resizable = false;
            this.Text = "About";
            this.TransparencyKey = System.Drawing.Color.Empty;
            ((System.ComponentModel.ISupportInitialize)(this.Github)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Github;
        private System.Windows.Forms.RichTextBox AboutBox;
        private new MetroFramework.Components.MetroStyleManager StyleManager;
    }
}