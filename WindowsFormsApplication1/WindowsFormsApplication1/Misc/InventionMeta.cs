using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuneHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AftershockIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After dealing 50,000 damage, create an explosion centered on your \ncurrent target, dealing up to 40% per rank weapon damage to nearby enemies.\nRequires 5 Ilujankan Components, gathered by disassembling Zarosion Items from the Heart.");
        }

        private void PreciseIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Increases your minimum damage by 1.5% per rank of your maximum damage.\nRequires 5 Armadyl Components, gathered by dissassembling Armadyl or Armadyl Warpriest Items.");
        }

        private void CracklingIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Periodically zaps your combat target for 50% per rank of your weapon's damage (or 10% per rank in PvP).\nRequires 4 Explosive Components and 1 Imbued Component, Gathered by disassembling Hand Cannons and Battlestaves respectively.");
        }

        private void ImpatientIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("9% chance per rank for basic abilities to generate 3 extra adrenaline.\nGained from 5 Zamorak Components, Gathered by disassembling Zamorak or Zamorak Warpriest items.");
        }

        private void BitingIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+2% chance per rank to critically hit opponents.\nRequires 5 Noxious Components for Biting 3, or 5 Direct Components for Biting 2, Gathered by disassembling Noxious Weaponry or pickaxes respectively.");
        }

        private void EnhDevoIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4.5% chance per rank on being hit that protection prayers will work at 100% (or 75% in PvP) for 3 seconds. This does not stack with devoted.\nRequires 5 Faceted Components, gathered by disassembling Crystal Weaponry or flasks.");
        }
    }
}
