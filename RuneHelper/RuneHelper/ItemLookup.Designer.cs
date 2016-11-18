namespace RuneHelper
{
    partial class ItemLookup
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
            this.CatagoryBox = new MetroFramework.Controls.MetroComboBox();
            this.SearchButton = new MetroFramework.Controls.MetroButton();
            this.SearchInput = new MetroFramework.Controls.MetroTextBox();
            this.ResultListView = new MetroFramework.Controls.MetroListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemImage = new System.Windows.Forms.PictureBox();
            this.ItemNameLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Description = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.PriceLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CatagoryBox
            // 
            this.CatagoryBox.FormattingEnabled = true;
            this.CatagoryBox.ItemHeight = 23;
            this.CatagoryBox.Items.AddRange(new object[] {
            "Miscellaneous",
            "Ammo",
            "Arrows",
            "Bolts",
            "Construction materials",
            "Construction projects",
            "Cooking ingredients",
            "Costumes",
            "Crafting materials",
            "Familiars",
            "Farming produce",
            "Fletching materials",
            "Food and drink",
            "Herblore materials",
            "Hunting equipment",
            "Hunting produce",
            "Jewellery",
            "Mage armour",
            "Mage weapons",
            "Melee armour - low level",
            "Melee armour - mid level",
            "Melee armour - high level",
            "Melee weapons - low level",
            "Melee weapons - mid level",
            "Melee weapons - high level",
            "Mining and smithing",
            "Potions",
            "Prayer armour",
            "Prayer materials",
            "Range armour",
            "Range weapons",
            "Runecrafting",
            "Runes, Spells and Teleports",
            "Seeds",
            "Summoning scrolls",
            "Tools and containers",
            "Woodcutting product",
            "Pocket items"});
            this.CatagoryBox.Location = new System.Drawing.Point(203, 63);
            this.CatagoryBox.Name = "CatagoryBox";
            this.CatagoryBox.Size = new System.Drawing.Size(180, 29);
            this.CatagoryBox.TabIndex = 0;
            this.CatagoryBox.UseSelectable = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(14, 92);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(93, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseSelectable = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchInput
            // 
            // 
            // 
            // 
            this.SearchInput.CustomButton.Image = null;
            this.SearchInput.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.SearchInput.CustomButton.Name = "";
            this.SearchInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchInput.CustomButton.TabIndex = 1;
            this.SearchInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchInput.CustomButton.UseSelectable = true;
            this.SearchInput.CustomButton.Visible = false;
            this.SearchInput.Lines = new string[0];
            this.SearchInput.Location = new System.Drawing.Point(14, 63);
            this.SearchInput.MaxLength = 32767;
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.PasswordChar = '\0';
            this.SearchInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchInput.SelectedText = "";
            this.SearchInput.SelectionLength = 0;
            this.SearchInput.SelectionStart = 0;
            this.SearchInput.ShortcutsEnabled = true;
            this.SearchInput.ShowClearButton = true;
            this.SearchInput.Size = new System.Drawing.Size(183, 23);
            this.SearchInput.TabIndex = 2;
            this.SearchInput.UseSelectable = true;
            this.SearchInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ResultListView
            // 
            this.ResultListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ItemID,
            this.Price});
            this.ResultListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResultListView.FullRowSelect = true;
            this.ResultListView.Location = new System.Drawing.Point(14, 132);
            this.ResultListView.MultiSelect = false;
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.OwnerDraw = true;
            this.ResultListView.Size = new System.Drawing.Size(369, 172);
            this.ResultListView.Style = MetroFramework.MetroColorStyle.Green;
            this.ResultListView.TabIndex = 3;
            this.ResultListView.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.UseCustomBackColor = true;
            this.ResultListView.UseCustomForeColor = true;
            this.ResultListView.UseSelectable = true;
            this.ResultListView.UseStyleColors = true;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            this.ResultListView.ItemActivate += new System.EventHandler(this.ResultListView_ItemActivate);
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 159;
            // 
            // ItemID
            // 
            this.ItemID.Text = "Item ID";
            this.ItemID.Width = 81;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 82;
            // 
            // ItemImage
            // 
            this.ItemImage.InitialImage = null;
            this.ItemImage.Location = new System.Drawing.Point(14, 311);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(93, 89);
            this.ItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ItemImage.TabIndex = 4;
            this.ItemImage.TabStop = false;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(14, 403);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(58, 19);
            this.ItemNameLabel.TabIndex = 5;
            this.ItemNameLabel.Text = "Pack Yak";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(113, 311);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Description";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(113, 330);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(0, 0);
            this.Description.TabIndex = 7;
            this.Description.WrapToLine = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(113, 353);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Price";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(113, 377);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 0);
            this.PriceLabel.TabIndex = 9;
            // 
            // ItemLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 500);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.ItemImage);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CatagoryBox);
            this.Name = "ItemLookup";
            this.Text = "ItemLookup";
            this.Load += new System.EventHandler(this.ItemLookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox CatagoryBox;
        private MetroFramework.Controls.MetroButton SearchButton;
        private MetroFramework.Controls.MetroTextBox SearchInput;
        private MetroFramework.Controls.MetroListView ResultListView;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.PictureBox ItemImage;
        private MetroFramework.Controls.MetroLabel ItemNameLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel Description;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel PriceLabel;
    }
}