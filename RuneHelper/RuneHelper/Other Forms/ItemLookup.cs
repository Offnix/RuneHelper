﻿using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RuneHelper
{
    public partial class ItemLookup : MetroForm
    {
        public ItemLookup()
        {
            InitializeComponent();
        }

        private JObject jObject;

        #region Open And Close Functions

        private void ItemLookup_Load(object sender, EventArgs e)
        {
            StyleManager.Theme = API.GetTheme(MainForm.SaveData[1]);
            StyleManager.Style = API.GetColour(MainForm.SaveData[2]);
            this.Theme = StyleManager.Theme;
            ResultListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ResultListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion Open And Close Functions

        #region Form Controls

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchFunction();
        }

        private void ResultListView_ItemActivate(Object sender, EventArgs e)
        {
            int number = Convert.ToInt32(ResultListView.SelectedItems[0].Index);
            // first page of data
            ItemImage.Load((string)jObject["items"][number]["icon_large"]);
            ItemNameLabel.Text = (string)jObject["items"][number]["name"];
            Description.Text = (string)jObject["items"][number]["description"];
            ItemIDLabel.Text = (string)jObject["items"][number]["id"];
            // second page
            PriceLabel.Text = (string)jObject["items"][number]["current"]["price"];
            PriceTrend.Text = (string)jObject["items"][number]["current"]["trend"];
            CurrentPriceLabel.Text = (string)jObject["items"][number]["today"]["price"];
            CurrentPriceTrend.Text = (string)jObject["items"][number]["today"]["trend"];
        }

        #endregion Form Controls

        #region Events and Functions

        private void SearchInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SearchFunction();
            }
        }

        public void SearchFunction()
        {
            string Input = SearchInput.Text.Replace(" ", "+");
            try
            {
                WebClient client = new WebClient();
                client.Proxy = null;
                Stream stream = client.OpenRead("http://services.runescape.com/m=itemdb_rs/api/catalogue/items.json?category=" + CatagoryBox.SelectedIndex + "&alpha=" + Input + "&page=1");
                StreamReader reader = new StreamReader(stream);
                jObject = JObject.Parse(reader.ReadLine());
                stream.Close();
            }
            catch
            {
            }

            ResultListView.BeginUpdate();
            ResultListView.Items.Clear();

            int i = 0;
            try
            {
                while (true)
                {
                    var lvi = new ListViewItem(new string[] { (string)jObject["items"][i]["name"], (string)jObject["items"][i]["id"], (string)jObject["items"][i]["current"]["price"] });
                    ResultListView.Items.Add(lvi);
                    i++;
                }
            }
            catch
            {
                ResultListView.EndUpdate();
            }
        }

        #endregion Events and Functions
    }
}