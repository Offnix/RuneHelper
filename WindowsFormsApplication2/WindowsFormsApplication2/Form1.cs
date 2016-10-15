using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private Pen myPen;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            myPen = new System.Drawing.Pen(System.Drawing.Color.Gray);
            int lineamount = 0;
            int X1 = 0;
            int Y1 = 0;
            while (lineamount != 100)
            {
                formGraphics.DrawLine(myPen, X1, Y1, 200, 200);
                lineamount++;
                X1 = X1 + 1;
                Y1 = Y1 + 2;
            }
        }
    }
}
