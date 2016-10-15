using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g;

            g = e.Graphics;

            Pen myPen = new Pen(Color.Gray);
            myPen.Width = 1;
            int linecount = 0;
            int NewY;
            Random Rnd = new Random();

            NewY = Rnd.Next(200, 600);
            while (linecount !=  1000)
            {
                if(NewY < 0)
                {
                    NewY = Rnd.Next(200, 600);
                }
                NewY = Rnd.Next(NewY - 30, NewY + 30);
                g.DrawLine(myPen, linecount, 900 , linecount, NewY);
                linecount++;
            }
            
        }

    }
}
