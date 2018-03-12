using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Graphics g;
        Pen p;
        Font f;
        Brush b;
        double[] x = null;
        double[] y = null;
        Point[] po = null;
        int i;
            private void button1_Click(object sender, EventArgs e)
        {
            int x1, x2, y1, y2;
            x1 = 0;y1 = listBox1.Height / 2;
            x2 = listBox1.Width;y2 = y1;
            g = listBox1.CreateGraphics();
            p = Pens.Red;
            g.DrawLine(p,x1,y1,x2,y2);
            x1 = listBox1.Width/2; y1 =0;
            x2 = listBox1.Width/2; y2 = listBox1.Height;
            p = Pens.Teal;
            g.DrawLine(p, x1, y1, x2, y2);
            f = new Font("Tahoma",10);
            b = Brushes.Aqua;
            g.DrawString("X",f,b,listBox1.Width-20,listBox1.Height/2+5);
            x = new double[101];
            y = new double[101];
            po = new Point[101];
            for (i = 0; i <= 100; i++)
            {
                x[i] = -1 + 0.01 * i;
                y[i] = Math.Pow(x[i],2);

            }

            for (i = 0; i <= 100; i++)
            {
                po[i].X = Convert.ToInt32(x[i] * 20) + listBox1.Width / 2;
                po[i].Y = -Convert.ToInt32(y[i] * 20) + listBox1.Height / 2;

            }
            g.DrawPolygon(p,po);
            double z = 12.34567;
            double r =    Math.Round(z,1);
            MessageBox.Show(Convert.ToString(r));
        }
    }
}
