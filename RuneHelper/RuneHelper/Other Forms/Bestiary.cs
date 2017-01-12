using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RuneHelper
{
    public partial class Bestiary : MetroForm
    {
        public Bestiary()
        {
            InitializeComponent();
        }
        public class BeastData
        {
            public string name { get; set; }
            public int id { get; set; }
            public bool members { get; set; }
            public string weakness { get; set; }
            public int level { get; set; }
            public int lifepoints { get; set; }
            public int defence { get; set; }
            public int attack { get; set; }
            public int magic { get; set; }
            public int ranged { get; set; }
            public string xp { get; set; }
            public int slayerlevel { get; set; }
            public string slayercat { get; set; }
            public int size { get; set; }
            public bool attackable { get; set; }
            public bool aggresive { get; set; }
            public bool poisonous { get; set; }
            public string description { get; set; }
            public string[] area { get; set; }
        }

        public dynamic json1;
        public BeastData json2;
        private int i;

        #region Open And Close Functions

        private void ItemLookup_Load(object sender, EventArgs e)
        {
            StyleManager.Theme = MainForm.data.Theme;
            StyleManager.Style = MainForm.data.Colour;
            this.Theme = StyleManager.Theme;
            ResultListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ResultListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion Open And Close Functions

        #region Form Controls

        // if
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchFunction();
        }

        // updates the tab list page items depending on item selected
        private void ResultListView_ItemActivate(Object sender, EventArgs e)
        {
            Console.WriteLine("test fam");
            WebClient client = new WebClient();
            client.Proxy = null;
            Stream stream = client.OpenRead("http://services.runescape.com/m=itemdb_rs/bestiary/beastData.json?beastid=" + (string)json1[Convert.ToInt32(ResultListView.SelectedItems[0].Index)]["value"]);
            StreamReader reader = new StreamReader(stream);
            var json = reader.ReadToEnd();
            json2 = JsonConvert.DeserializeObject<BeastData>(json);
            // Basic Information
            ItemNameLabel.Text = json2.name;
            DescriptionLabel.Text = json2.description;
            ItemIDLabel.Text = json2.id.ToString();
            AggresiveLabel.Text = json2.aggresive.ToString();
            AttackableLabel.Text = json2.attackable.ToString();
            MembersLabel.Text = json2.members.ToString();
            // combat stats
            XpLabel.Text = json2.xp.ToString();
            SlayerCatLabel.Text = json2.slayercat;
            LevelLabel.Text = json2.level.ToString();
            WeaknessLabel.Text = json2.weakness;
            PoisonousLabel.Text = json2.poisonous.ToString();
            LifePointsLabel.Text = json2.lifepoints.ToString();
            AttackLabel.Text = json2.attack.ToString();
            RangedLabel.Text = json2.ranged.ToString();
            MagicLabel.Text = json2.magic.ToString();
        }

        // enter key event incase the person is to lazy to press the search button
        private void SearchInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SearchFunction();
            }
        }

        #endregion Form Controls

        #region Functions

        // search item function
        public void SearchFunction()
        {
            string Input = SearchInput.Text.Replace(" ", "+");
            try
            {
                WebClient client = new WebClient();
                client.Proxy = null;
                Stream stream = client.OpenRead("http://services.runescape.com/m=itemdb_rs/bestiary/beastSearch.json?term=" + Input);
                StreamReader reader = new StreamReader(stream);
                var json = reader.ReadToEnd();
                json1 = JsonConvert.DeserializeObject<dynamic[]>(json);

                stream.Close();
            }
            catch
            {
            }

            ResultListView.BeginUpdate();
            ResultListView.Items.Clear();

            i = 0;
            Console.WriteLine();
             try
            {
                while (true)
                {
                    var lvi = new ListViewItem(new string[] { (string)json1[i].label, (string)json1[i].value });
                    ResultListView.Items.Add(lvi);
                    i++;
                }
            }
            catch
            {
                ResultListView.EndUpdate();
            }
        }

        #endregion Functions
    }
}