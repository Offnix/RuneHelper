namespace RuneHelper
{
    partial class Bestiary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bestiary));
            this.SearchButton = new MetroFramework.Controls.MetroButton();
            this.SearchInput = new MetroFramework.Controls.MetroTextBox();
            this.ItemNameLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.XpLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.ResultListView = new MetroFramework.Controls.MetroListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.DescriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.AttackableLabel = new MetroFramework.Controls.MetroLabel();
            this.ItemIDLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.MembersLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.SlayerCatLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.AggresiveLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.PoisonousLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.WeaknessLabel = new MetroFramework.Controls.MetroLabel();
            this.MagicLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.LifePointsLabel = new MetroFramework.Controls.MetroLabel();
            this.Magic = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.RangedLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.AttackLabel = new MetroFramework.Controls.MetroLabel();
            this.LevelLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.DefenceLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(23, 92);
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
            this.SearchInput.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.SearchInput.CustomButton.Name = "";
            this.SearchInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchInput.CustomButton.TabIndex = 1;
            this.SearchInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchInput.CustomButton.UseSelectable = true;
            this.SearchInput.CustomButton.Visible = false;
            this.SearchInput.Lines = new string[0];
            this.SearchInput.Location = new System.Drawing.Point(23, 63);
            this.SearchInput.MaxLength = 32767;
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.PasswordChar = '\0';
            this.SearchInput.PromptText = "Item name";
            this.SearchInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchInput.SelectedText = "";
            this.SearchInput.SelectionLength = 0;
            this.SearchInput.SelectionStart = 0;
            this.SearchInput.ShortcutsEnabled = true;
            this.SearchInput.ShowClearButton = true;
            this.SearchInput.Size = new System.Drawing.Size(237, 23);
            this.SearchInput.TabIndex = 2;
            this.SearchInput.UseSelectable = true;
            this.SearchInput.WaterMark = "Item name";
            this.SearchInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchInput_KeyDown);
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ItemNameLabel.Location = new System.Drawing.Point(147, 11);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(0, 0);
            this.ItemNameLabel.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(273, 158);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Xp per Kill";
            // 
            // XpLabel
            // 
            this.XpLabel.AutoSize = true;
            this.XpLabel.Location = new System.Drawing.Point(292, 177);
            this.XpLabel.Name = "XpLabel";
            this.XpLabel.Size = new System.Drawing.Size(0, 0);
            this.XpLabel.TabIndex = 7;
            this.XpLabel.WrapToLine = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(14, 138);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(387, 369);
            this.metroTabControl1.TabIndex = 10;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.ResultListView);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(379, 327);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Select";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // ResultListView
            // 
            this.ResultListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ItemID});
            this.ResultListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResultListView.FullRowSelect = true;
            this.ResultListView.Location = new System.Drawing.Point(0, 21);
            this.ResultListView.MultiSelect = false;
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.OwnerDraw = true;
            this.ResultListView.Size = new System.Drawing.Size(379, 290);
            this.ResultListView.TabIndex = 4;
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
            this.ItemName.Width = 260;
            // 
            // ItemID
            // 
            this.ItemID.Text = "Item ID";
            this.ItemID.Width = 136;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel12);
            this.metroTabPage2.Controls.Add(this.DescriptionLabel);
            this.metroTabPage2.Controls.Add(this.metroLabel11);
            this.metroTabPage2.Controls.Add(this.AttackableLabel);
            this.metroTabPage2.Controls.Add(this.ItemIDLabel);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.ItemNameLabel);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.MembersLabel);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(379, 327);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Basic Information";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(-4, 107);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(74, 19);
            this.metroLabel12.TabIndex = 18;
            this.metroLabel12.Text = "Description";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(0, 126);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(0, 0);
            this.DescriptionLabel.TabIndex = 19;
            this.DescriptionLabel.WrapToLine = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(88, 41);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(70, 19);
            this.metroLabel11.TabIndex = 16;
            this.metroLabel11.Text = "Attackable";
            // 
            // AttackableLabel
            // 
            this.AttackableLabel.AutoSize = true;
            this.AttackableLabel.Location = new System.Drawing.Point(110, 60);
            this.AttackableLabel.Name = "AttackableLabel";
            this.AttackableLabel.Size = new System.Drawing.Size(0, 0);
            this.AttackableLabel.TabIndex = 17;
            this.AttackableLabel.WrapToLine = true;
            // 
            // ItemIDLabel
            // 
            this.ItemIDLabel.AutoSize = true;
            this.ItemIDLabel.Location = new System.Drawing.Point(196, 60);
            this.ItemIDLabel.Name = "ItemIDLabel";
            this.ItemIDLabel.Size = new System.Drawing.Size(0, 0);
            this.ItemIDLabel.TabIndex = 9;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(182, 41);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Animal ID";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(5, 41);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Members";
            // 
            // MembersLabel
            // 
            this.MembersLabel.AutoSize = true;
            this.MembersLabel.Location = new System.Drawing.Point(24, 60);
            this.MembersLabel.Name = "MembersLabel";
            this.MembersLabel.Size = new System.Drawing.Size(0, 0);
            this.MembersLabel.TabIndex = 13;
            this.MembersLabel.WrapToLine = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.SlayerCatLabel);
            this.metroTabPage3.Controls.Add(this.metroLabel16);
            this.metroTabPage3.Controls.Add(this.metroLabel15);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.AggresiveLabel);
            this.metroTabPage3.Controls.Add(this.metroLabel14);
            this.metroTabPage3.Controls.Add(this.PoisonousLabel);
            this.metroTabPage3.Controls.Add(this.metroLabel13);
            this.metroTabPage3.Controls.Add(this.WeaknessLabel);
            this.metroTabPage3.Controls.Add(this.MagicLabel);
            this.metroTabPage3.Controls.Add(this.metroLabel1);
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.Controls.Add(this.XpLabel);
            this.metroTabPage3.Controls.Add(this.metroLabel7);
            this.metroTabPage3.Controls.Add(this.LifePointsLabel);
            this.metroTabPage3.Controls.Add(this.Magic);
            this.metroTabPage3.Controls.Add(this.metroLabel10);
            this.metroTabPage3.Controls.Add(this.RangedLabel);
            this.metroTabPage3.Controls.Add(this.metroLabel8);
            this.metroTabPage3.Controls.Add(this.AttackLabel);
            this.metroTabPage3.Controls.Add(this.LevelLabel);
            this.metroTabPage3.Controls.Add(this.metroLabel9);
            this.metroTabPage3.Controls.Add(this.DefenceLabel);
            this.metroTabPage3.Controls.Add(this.metroLabel5);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(379, 327);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Combat";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // SlayerCatLabel
            // 
            this.SlayerCatLabel.AutoSize = true;
            this.SlayerCatLabel.Location = new System.Drawing.Point(273, 227);
            this.SlayerCatLabel.Name = "SlayerCatLabel";
            this.SlayerCatLabel.Size = new System.Drawing.Size(0, 0);
            this.SlayerCatLabel.TabIndex = 31;
            this.SlayerCatLabel.WrapToLine = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(252, 208);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(103, 19);
            this.metroLabel16.TabIndex = 30;
            this.metroLabel16.Text = "Slayer Category";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.Location = new System.Drawing.Point(246, 123);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(118, 25);
            this.metroLabel15.TabIndex = 29;
            this.metroLabel15.Text = "Slayer And XP";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(2, 196);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Aggresive";
            // 
            // AggresiveLabel
            // 
            this.AggresiveLabel.AutoSize = true;
            this.AggresiveLabel.Location = new System.Drawing.Point(17, 216);
            this.AggresiveLabel.Name = "AggresiveLabel";
            this.AggresiveLabel.Size = new System.Drawing.Size(0, 0);
            this.AggresiveLabel.TabIndex = 15;
            this.AggresiveLabel.WrapToLine = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.Location = new System.Drawing.Point(-4, 123);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(149, 25);
            this.metroLabel14.TabIndex = 28;
            this.metroLabel14.Text = "Combat Attributes";
            // 
            // PoisonousLabel
            // 
            this.PoisonousLabel.AutoSize = true;
            this.PoisonousLabel.Location = new System.Drawing.Point(16, 177);
            this.PoisonousLabel.Name = "PoisonousLabel";
            this.PoisonousLabel.Size = new System.Drawing.Size(0, 0);
            this.PoisonousLabel.TabIndex = 27;
            this.PoisonousLabel.WrapToLine = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(2, 158);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(67, 19);
            this.metroLabel13.TabIndex = 26;
            this.metroLabel13.Text = "Poisonous";
            // 
            // WeaknessLabel
            // 
            this.WeaknessLabel.AutoSize = true;
            this.WeaknessLabel.Location = new System.Drawing.Point(94, 177);
            this.WeaknessLabel.Name = "WeaknessLabel";
            this.WeaknessLabel.Size = new System.Drawing.Size(0, 0);
            this.WeaknessLabel.TabIndex = 11;
            this.WeaknessLabel.WrapToLine = true;
            // 
            // MagicLabel
            // 
            this.MagicLabel.AutoSize = true;
            this.MagicLabel.Location = new System.Drawing.Point(273, 79);
            this.MagicLabel.Name = "MagicLabel";
            this.MagicLabel.Size = new System.Drawing.Size(16, 19);
            this.MagicLabel.TabIndex = 25;
            this.MagicLabel.Text = "0";
            this.MagicLabel.WrapToLine = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(75, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Weakness";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(40, 60);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Health";
            // 
            // LifePointsLabel
            // 
            this.LifePointsLabel.AutoSize = true;
            this.LifePointsLabel.Location = new System.Drawing.Point(48, 79);
            this.LifePointsLabel.Name = "LifePointsLabel";
            this.LifePointsLabel.Size = new System.Drawing.Size(16, 19);
            this.LifePointsLabel.TabIndex = 17;
            this.LifePointsLabel.Text = "0";
            this.LifePointsLabel.WrapToLine = true;
            // 
            // Magic
            // 
            this.Magic.AutoSize = true;
            this.Magic.Location = new System.Drawing.Point(265, 60);
            this.Magic.Name = "Magic";
            this.Magic.Size = new System.Drawing.Size(45, 19);
            this.Magic.TabIndex = 24;
            this.Magic.Text = "Magic";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(205, 60);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(54, 19);
            this.metroLabel10.TabIndex = 22;
            this.metroLabel10.Text = "Ranged";
            // 
            // RangedLabel
            // 
            this.RangedLabel.AutoSize = true;
            this.RangedLabel.Location = new System.Drawing.Point(215, 79);
            this.RangedLabel.Name = "RangedLabel";
            this.RangedLabel.Size = new System.Drawing.Size(16, 19);
            this.RangedLabel.TabIndex = 23;
            this.RangedLabel.Text = "0";
            this.RangedLabel.WrapToLine = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(92, 60);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(45, 19);
            this.metroLabel8.TabIndex = 18;
            this.metroLabel8.Text = "Attack";
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.Location = new System.Drawing.Point(100, 79);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(16, 19);
            this.AttackLabel.TabIndex = 19;
            this.AttackLabel.Text = "0";
            this.AttackLabel.WrapToLine = true;
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(155, 41);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(16, 19);
            this.LevelLabel.TabIndex = 15;
            this.LevelLabel.Text = "0";
            this.LevelLabel.WrapToLine = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(143, 60);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(56, 19);
            this.metroLabel9.TabIndex = 20;
            this.metroLabel9.Text = "Defence";
            // 
            // DefenceLabel
            // 
            this.DefenceLabel.AutoSize = true;
            this.DefenceLabel.Location = new System.Drawing.Point(153, 79);
            this.DefenceLabel.Name = "DefenceLabel";
            this.DefenceLabel.Size = new System.Drawing.Size(16, 19);
            this.DefenceLabel.TabIndex = 21;
            this.DefenceLabel.Text = "0";
            this.DefenceLabel.WrapToLine = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(107, 16);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(115, 25);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Combat Level";
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            // 
            // Bestiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 500);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.SearchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bestiary";
            this.Resizable = false;
            this.Text = "Bestiary";
            this.Load += new System.EventHandler(this.ItemLookup_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton SearchButton;
        private MetroFramework.Controls.MetroTextBox SearchInput;
        private MetroFramework.Controls.MetroLabel ItemNameLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel XpLabel;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel ItemIDLabel;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private new MetroFramework.Components.MetroStyleManager StyleManager;
        private MetroFramework.Controls.MetroLabel WeaknessLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel MembersLabel;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel MagicLabel;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel LifePointsLabel;
        private MetroFramework.Controls.MetroLabel Magic;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel RangedLabel;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel AttackLabel;
        private MetroFramework.Controls.MetroLabel LevelLabel;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel DefenceLabel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroListView ResultListView;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel AggresiveLabel;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel AttackableLabel;
        private MetroFramework.Controls.MetroLabel PoisonousLabel;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel DescriptionLabel;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel SlayerCatLabel;
        private MetroFramework.Controls.MetroLabel metroLabel16;
    }
}