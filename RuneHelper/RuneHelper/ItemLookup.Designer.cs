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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemLookup));
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.ItemIDLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.CurrentPriceLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.CurrentPriceTrend = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.PriceTrend = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
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
            this.ResultListView.Location = new System.Drawing.Point(14, 121);
            this.ResultListView.MultiSelect = false;
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.OwnerDraw = true;
            this.ResultListView.Size = new System.Drawing.Size(369, 189);
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
            this.ItemImage.BackColor = System.Drawing.Color.Transparent;
            this.ItemImage.InitialImage = null;
            this.ItemImage.Location = new System.Drawing.Point(0, 15);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(93, 89);
            this.ItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ItemImage.TabIndex = 4;
            this.ItemImage.TabStop = false;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(0, 107);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(0, 0);
            this.ItemNameLabel.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(99, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Description";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(99, 34);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(0, 0);
            this.Description.TabIndex = 7;
            this.Description.WrapToLine = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(-4, 87);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Price";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(0, 106);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(16, 19);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "0";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(14, 312);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(368, 187);
            this.metroTabControl1.TabIndex = 10;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.ItemIDLabel);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.ItemImage);
            this.metroTabPage1.Controls.Add(this.Description);
            this.metroTabPage1.Controls.Add(this.ItemNameLabel);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(360, 145);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Basic Info";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // ItemIDLabel
            // 
            this.ItemIDLabel.AutoSize = true;
            this.ItemIDLabel.Location = new System.Drawing.Point(99, 78);
            this.ItemIDLabel.Name = "ItemIDLabel";
            this.ItemIDLabel.Size = new System.Drawing.Size(0, 0);
            this.ItemIDLabel.TabIndex = 9;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(99, 59);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Item ID";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.CurrentPriceLabel);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.CurrentPriceTrend);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.PriceTrend);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.PriceLabel);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(360, 145);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Grand Exchange";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // CurrentPriceLabel
            // 
            this.CurrentPriceLabel.AutoSize = true;
            this.CurrentPriceLabel.Location = new System.Drawing.Point(140, 106);
            this.CurrentPriceLabel.Name = "CurrentPriceLabel";
            this.CurrentPriceLabel.Size = new System.Drawing.Size(16, 19);
            this.CurrentPriceLabel.TabIndex = 16;
            this.CurrentPriceLabel.Text = "0";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(136, 87);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(84, 19);
            this.metroLabel9.TabIndex = 15;
            this.metroLabel9.Text = "Price change";
            // 
            // CurrentPriceTrend
            // 
            this.CurrentPriceTrend.AutoSize = true;
            this.CurrentPriceTrend.Location = new System.Drawing.Point(136, 60);
            this.CurrentPriceTrend.Name = "CurrentPriceTrend";
            this.CurrentPriceTrend.Size = new System.Drawing.Size(52, 19);
            this.CurrentPriceTrend.TabIndex = 14;
            this.CurrentPriceTrend.Text = "Neutral";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(136, 41);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(73, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Price trend";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(136, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Current";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(-4, 9);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Today";
            // 
            // PriceTrend
            // 
            this.PriceTrend.AutoSize = true;
            this.PriceTrend.Location = new System.Drawing.Point(-4, 60);
            this.PriceTrend.Name = "PriceTrend";
            this.PriceTrend.Size = new System.Drawing.Size(52, 19);
            this.PriceTrend.TabIndex = 10;
            this.PriceTrend.Text = "Neutral";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(-4, 41);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Price trend";
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            // 
            // ItemLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 500);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CatagoryBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ItemLookup";
            this.Resizable = false;
            this.Text = "ItemLookup";
            this.Load += new System.EventHandler(this.ItemLookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);

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
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel PriceTrend;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel CurrentPriceLabel;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel CurrentPriceTrend;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel ItemIDLabel;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}