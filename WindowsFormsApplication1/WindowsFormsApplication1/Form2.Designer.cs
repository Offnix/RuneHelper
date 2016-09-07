namespace WindowsFormsApplication1
{
    partial class SilverhawkForm
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
            this.CharNameBox = new System.Windows.Forms.TextBox();
            this.CharSearchButton = new System.Windows.Forms.Button();
            this.WebReturnBox = new System.Windows.Forms.TextBox();
            this.XpLabel = new System.Windows.Forms.Label();
            this.TargetBox = new System.Windows.Forms.TextBox();
            this.TargetLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CharNameBox
            // 
            this.CharNameBox.Location = new System.Drawing.Point(15, 34);
            this.CharNameBox.Name = "CharNameBox";
            this.CharNameBox.Size = new System.Drawing.Size(140, 20);
            this.CharNameBox.TabIndex = 0;
            this.CharNameBox.Text = "Enter Character Name Here";
            // 
            // CharSearchButton
            // 
            this.CharSearchButton.Location = new System.Drawing.Point(194, 32);
            this.CharSearchButton.Name = "CharSearchButton";
            this.CharSearchButton.Size = new System.Drawing.Size(75, 23);
            this.CharSearchButton.TabIndex = 1;
            this.CharSearchButton.Text = "Search";
            this.CharSearchButton.UseVisualStyleBackColor = true;
            this.CharSearchButton.Click += new System.EventHandler(this.CharSearchButton_Click);
            // 
            // WebReturnBox
            // 
            this.WebReturnBox.Location = new System.Drawing.Point(88, 74);
            this.WebReturnBox.Name = "WebReturnBox";
            this.WebReturnBox.Size = new System.Drawing.Size(189, 20);
            this.WebReturnBox.TabIndex = 2;
            this.WebReturnBox.Visible = false;
            // 
            // XpLabel
            // 
            this.XpLabel.AutoSize = true;
            this.XpLabel.Location = new System.Drawing.Point(12, 77);
            this.XpLabel.Name = "XpLabel";
            this.XpLabel.Size = new System.Drawing.Size(51, 13);
            this.XpLabel.TabIndex = 3;
            this.XpLabel.Text = "Agility XP";
            this.XpLabel.Visible = false;
            // 
            // TargetBox
            // 
            this.TargetBox.Location = new System.Drawing.Point(161, 122);
            this.TargetBox.Name = "TargetBox";
            this.TargetBox.Size = new System.Drawing.Size(116, 20);
            this.TargetBox.TabIndex = 4;
            this.TargetBox.Visible = false;
            // 
            // TargetLabel
            // 
            this.TargetLabel.AutoSize = true;
            this.TargetLabel.Location = new System.Drawing.Point(12, 122);
            this.TargetLabel.Name = "TargetLabel";
            this.TargetLabel.Size = new System.Drawing.Size(124, 13);
            this.TargetLabel.TabIndex = 5;
            this.TargetLabel.Text = "Enter Target Level or XP";
            this.TargetLabel.Visible = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(125, 170);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Visible = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // SilverhawkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 415);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TargetLabel);
            this.Controls.Add(this.TargetBox);
            this.Controls.Add(this.XpLabel);
            this.Controls.Add(this.WebReturnBox);
            this.Controls.Add(this.CharSearchButton);
            this.Controls.Add(this.CharNameBox);
            this.Name = "SilverhawkForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CharNameBox;
        private System.Windows.Forms.Button CharSearchButton;
        private System.Windows.Forms.TextBox WebReturnBox;
        private System.Windows.Forms.Label XpLabel;
        private System.Windows.Forms.TextBox TargetBox;
        private System.Windows.Forms.Label TargetLabel;
        private System.Windows.Forms.Button CalculateButton;
    }
}