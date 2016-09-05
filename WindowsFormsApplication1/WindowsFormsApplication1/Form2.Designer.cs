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
            this.SuspendLayout();
            // 
            // CharNameBox
            // 
            this.CharNameBox.Location = new System.Drawing.Point(34, 36);
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
            this.WebReturnBox.Location = new System.Drawing.Point(34, 86);
            this.WebReturnBox.Multiline = true;
            this.WebReturnBox.Name = "WebReturnBox";
            this.WebReturnBox.Size = new System.Drawing.Size(302, 317);
            this.WebReturnBox.TabIndex = 2;
            // 
            // SilverhawkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 415);
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
    }
}