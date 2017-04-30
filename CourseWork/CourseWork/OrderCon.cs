using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class OrderCon : Form
    {
        Product product = new Product();

        public OrderCon()
        {
            InitializeComponent();

            product = new Cupboard("Usual","Wood","200","200","Glass","2","2");
            drawProduct();
            Bitmap bmp = new Bitmap(pb_shelf1.Width, pb_shelf1.Height);
            Graphics g = Graphics.FromImage(bmp);
            Pen p = new Pen(Color.FromArgb(200, 100, 100));
            g.DrawLine(p, 10, 40, 40, 10);
            g.DrawLine(p, 10, 40, 150, 40);
            g.DrawLine(p, 180, 10, 150, 40);
            g.DrawLine(p, 180, 10, 40,10);
            pb_shelf1.Image = bmp;

            bmp = new Bitmap(pb_shelf2.Width, pb_shelf2.Height);
            g = Graphics.FromImage(bmp);
            g.DrawLine(p, 10, 30, 40, 10);
            g.DrawLine(p, 10, 30, 150, 30);
            g.DrawLine(p, 180, 10, 150, 30);
            g.DrawLine(p, 180, 10, 40, 10);
            g.DrawRectangle(p, 10, 30, 140, 30);
            g.DrawLine(p, 180, 10, 180, 40);
            g.DrawLine(p, 150, 60, 180, 40);
            g.DrawEllipse(p, 70, 40, 15, 15);
            pb_shelf2.Image = bmp;
        }

        void drawProduct()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            
            Graphics g = Graphics.FromImage(bmp); 

            if(product is Cupboard)
            {
                Pen p = new Pen(Color.FromArgb(200, 100, 100));
                g.DrawRectangle(p, 50, 100, 200, 300);
                g.DrawLine(p, 50, 100, 80, 60);
                g.DrawLine(p, 250, 100, 280, 60);
                g.DrawLine(p, 280, 60, 80, 60);
                g.DrawLine(p, 280, 60, 280, 370);
                g.DrawLine(p, 250, 400, 280, 370);
                g.DrawLine(p, 80, 370, 250, 370);
                g.DrawLine(p, 80, 370, 50, 400);
                g.DrawLine(p, 80, 370, 80, 100);

                int n=Convert.ToInt32((product as Cupboard).shelf1);
                for (int i = 0; i < n; i++)
                {
                    drawSh1(g, 100 + i * 50, 200);
                }
                n = Convert.ToInt32((product as Cupboard).shelf2);
                for (int i = 0; i < n; i++)
                {
                    drawSh2(g, 360 - i * 50, 200);
                }

            }


            pictureBox1.Image = bmp;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        void drawSh1(Graphics g ,int ys,int w)
        {
            Pen p = new Pen(Color.FromArgb(200, 100, 100));
            g.DrawLine(p, 50, 40+ys, 80, 10+ys);
            g.DrawLine(p, 50, 40+ys, 50 + w, 40 + ys);
            g.DrawLine(p, 80 + w, 10 + ys, 50 + w, 40 + ys);
            g.DrawLine(p, 80 + w, 10 + ys, 80, 10 + ys);
        }

        void drawSh2(Graphics g, int ys, int w)
        {
            Pen p = new Pen(Color.FromArgb(255, 0, 0));
            //g.DrawLine(p, 50, 40 + ys, 80, 10 + ys);
            g.DrawLine(p, 50, 40 + ys, 50+w, 40 + ys);
            g.DrawLine(p, 50+w, 40 + ys, 80+w, 10 + ys);
            //g.DrawLine(p, 80, 10 + ys, 80+w, 10 + ys);
            g.DrawRectangle(p, 50, -10 + ys, w, 50 );
            g.DrawLine(p, 80+w, 10+ ys, 80+w, -40+ ys);
            g.DrawLine(p, 50 + w, -10 + ys, 80 + w, -40 + ys);
            g.DrawLine(p, 80, -40 + ys, 80 + w, -40 + ys);
            g.DrawLine(p, 80, -40 + ys, 50 , -10 + ys);
            g.DrawEllipse(p, 150, 10+ ys, 15, 15);
        }
    }
}
