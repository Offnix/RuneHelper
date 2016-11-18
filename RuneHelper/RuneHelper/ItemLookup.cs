using System;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;

namespace RuneHelper
{
    public partial class ItemLookup : MetroForm
    {
        public ItemLookup()
        {
            InitializeComponent();
        }

        JObject jObject;

        private void ItemLookup_Load(object sender, EventArgs e)
        {

            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string Input = SearchInput.Text.Replace(" ", "+");
            WebClient client = new WebClient();
            client.Proxy = null;
            Stream stream = client.OpenRead("http://services.runescape.com/m=itemdb_rs/api/catalogue/items.json?category="+ CatagoryBox.SelectedIndex + "&alpha="+Input+"&page=1");
            StreamReader reader = new StreamReader(stream);
            jObject = JObject.Parse(reader.ReadLine());
            stream.Close();
            ResultListView.Items.Clear();

            ResultListView.BeginUpdate();
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

        private void ResultListView_ItemActivate(Object sender, EventArgs e)
        {
            
            int number = Convert.ToInt32(ResultListView.SelectedItems[0].Index);
            ItemImage.Load((string)jObject["items"][number]["icon_large"]);
            ItemNameLabel.Text = (string)jObject["items"][number]["name"];
            Description.Text = (string)jObject["items"][number]["description"];
            PriceLabel.Text = (string)jObject["items"][number]["current"]["price"];


        }
    }
}
