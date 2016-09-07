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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SilverhawkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(171, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(86, 13);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Runescape Tool";
            // 
            // SilverhawkButton
            // 
            this.SilverhawkButton.Location = new System.Drawing.Point(120, 35);
            this.SilverhawkButton.Name = "SilverhawkButton";
            this.SilverhawkButton.Size = new System.Drawing.Size(195, 23);
            this.SilverhawkButton.TabIndex = 1;
            this.SilverhawkButton.Text = "Silverhawk Feather Calculator";
            this.SilverhawkButton.UseVisualStyleBackColor = true;
            this.SilverhawkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 462);
            this.Controls.Add(this.SilverhawkButton);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button SilverhawkButton;
    }
}

