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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Github = new System.Windows.Forms.PictureBox();
            this.AboutBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Github)).BeginInit();
            this.SuspendLayout();
            // 
            // Github
            // 
            this.Github.Image = ((System.Drawing.Image)(resources.GetObject("Github.Image")));
            this.Github.Location = new System.Drawing.Point(-1, 213);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(89, 86);
            this.Github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Github.TabIndex = 0;
            this.Github.TabStop = false;
            this.Github.Click += new System.EventHandler(this.Github_Click);
            // 
            // AboutBox
            // 
            this.AboutBox.Location = new System.Drawing.Point(-1, 0);
            this.AboutBox.Name = "AboutBox";
            this.AboutBox.ReadOnly = true;
            this.AboutBox.Size = new System.Drawing.Size(301, 209);
            this.AboutBox.TabIndex = 1;
            this.AboutBox.Text = resources.GetString("AboutBox.Text");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(305, 299);
            this.Controls.Add(this.AboutBox);
            this.Controls.Add(this.Github);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.Github)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Github;
        private System.Windows.Forms.RichTextBox AboutBox;
    }
}