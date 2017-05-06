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
        Product product ;

        public OrderCon()
        {
            InitializeComponent();

            comboBox1.Items.Add("Chair");
            comboBox1.Items.Add("Cupboard");
            comboBox1.Items.Add("Table");

            chairForm.Items.Add("Square");
            chairForm.Items.Add("Round");
            ChairType.Items.Add("Computer");
            ChairType.Items.Add("Kitchen");

            cupType.Items.Add("Closet");
            cupType.Items.Add("Usual");

            tableType.Items.Add("Computer");
            tableType.Items.Add("Kitchen");
            tableForm.Items.Add("Round");
            tableForm.Items.Add("Square");

            //DataTable dt = ConnectionClass.getResult(@"SELECT Login FROM Client;");
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    clientId.Items.Add(dt.Rows[i][0]);
            //}

            DataTable dt = ConnectionClass.getResult(@"SELECT Login FROM Client where ID="+ConnectionClass.ID+";");

            clientId.Items.Add(dt.Rows[0][0]);
            clientId.SelectedIndex = 0;

            dt = ConnectionClass.getResult(@"SELECT Material  FROM ProvidersList group by Material;");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chairMaterial.Items.Add(dt.Rows[i][0]);
                tableMaterial.Items.Add(dt.Rows[i][0]);
                doorMaterial.Items.Add(dt.Rows[i][0]);
                cupMaterial.Items.Add(dt.Rows[i][0]);
            }


            product = new Cupboard("Usual", "Wood", "200", "200", "Glass", "2");
            drawProduct();
            //Bitmap bmp = new Bitmap(shelf1.Width, shelf1.Height);
            //Graphics g = Graphics.FromImage(bmp);
            //Pen p = new Pen(Color.FromArgb(200, 100, 100));
            //g.DrawLine(p, 10, 40, 40, 10);
            //g.DrawLine(p, 10, 40, 150, 40);
            //g.DrawLine(p, 180, 10, 150, 40);
            //g.DrawLine(p, 180, 10, 40, 10);
            //shelf1.Image = bmp;

            //bmp = new Bitmap(pb_shelf2.Width, pb_shelf2.Height);
            //g = Graphics.FromImage(bmp);
            //g.DrawLine(p, 10, 30, 40, 10);
            //g.DrawLine(p, 10, 30, 150, 30);
            //g.DrawLine(p, 180, 10, 150, 30);
            //g.DrawLine(p, 180, 10, 40, 10);
            //g.DrawRectangle(p, 10, 30, 140, 30);
            //g.DrawLine(p, 180, 10, 180, 40);
            //g.DrawLine(p, 150, 60, 180, 40);
            //g.DrawEllipse(p, 70, 40, 15, 15);
            //pb_shelf2.Image = bmp;
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

                int n=Convert.ToInt32((product as Cupboard).shelfNum);
                for (int i = 0; i < n; i++)
                {
                    drawSh1(g, 100 + i * 50, 200);
                }
                //n = Convert.ToInt32((product as Cupboard).shelf2);
                //for (int i = 0; i < n; i++)
                //{
                //    drawSh2(g, 360 - i * 50, 200);
                //}

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Chair")
            {
                Chair.Left = 450;
                Table.Left = 1000;
                Cupboard.Left = 1000;

            }
            else if (comboBox1.Text == "Table")
            {
                Chair.Left = 1000;
                Table.Left = 450;
                Cupboard.Left = 1000;
            }
            else
            {
                Chair.Left = 1000;
                Table.Left = 1000;
                Cupboard.Left = 450;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = 0;
            if (comboBox1.SelectedIndex == 0)
            {
                product = new Chair(ChairType.Text, chairMaterial.Text, chairForm.Text, chairHeight.Text);
                p = product.getPrice();
                ConnectionClass.executeQuery("insert into Products(Type ,Material,VolMaterial ,DopMaterial ,VolDopMaterial ,Price ,Status ,Image ) values ('"
                    + comboBox1.Text + "','" + chairMaterial.Text + "','" + chairHeight.Value + "',null,null,'" +p + "','" + "InStore" + "','" + "image" + "');");
                
                DataTable dtb = ConnectionClass.getResult("select Volume from Material where Name='"+chairMaterial.Text+"';");
                if (dtb.Rows.Count > 0 &&.ToInt32(dtb.Rows[0][0].ToString()) >= Convert.ToInt32(chairHeight.Text))
                    MessageBox.Show("Price: " + p);
                else {
                    dtb = ConnectionClass.getResult("select min(Time) from ProvidersList where Material='" + chairMaterial.Text + "';");
                    MessageBox.Show("Price: " + p + "\r\nMin days: " + Convert.ToInt32(dtb.Rows[0][0].ToString()));
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                product = new Cupboard(cupType.Text, cupMaterial.Text, cupHeight.Text, cupWidth.Text, doorMaterial.Text, shelfNum.Text);
                p = product.getPrice();
                ConnectionClass.executeQuery("insert into Products(Type ,Material,VolMaterial ,DopMaterial ,VolDopMaterial ,Price ,Status ,Image ) values ('"
                    + comboBox1.Text + "','" + cupMaterial.Text + "','" + (cupHeight.Value*cupWidth.Value/10) + "','" + doorMaterial.Text + "','" + (cupHeight.Value * cupWidth.Value / 100) + "','" + p + "','" + "InStore" + "','" + "image" + "');");

                DataTable dtb = ConnectionClass.getResult("select Volume from Material where Name='" + cupMaterial.Text + "';");
                if (dtb.Rows.Count > 0 && Convert.ToInt32(dtb.Rows[0][0].ToString()) >= (cupHeight.Value * cupWidth.Value / 10))
                {
                    dtb = ConnectionClass.getResult("select Volume from Material where Name='" + doorMaterial.Text + "';");
                    if (dtb.Rows.Count > 0 && Convert.ToInt32(dtb.Rows[0][0].ToString()) >= (cupHeight.Value * cupWidth.Value / 100))
                    {
                        MessageBox.Show("Price: " + p);
                    }
                    else
                    {
                        dtb = ConnectionClass.getResult("select min(Time) from ProvidersList where Material='" + doorMaterial.Text + "';");
                        MessageBox.Show("Price: " + p + "\r\nMin days: " + Convert.ToInt32(dtb.Rows[0][0].ToString()));
                    }
                }
                else
                {
                    dtb = ConnectionClass.getResult("select Volume from Material where Name='" + doorMaterial.Text + "';");
                    if (dtb.Rows.Count > 0 && Convert.ToInt32(dtb.Rows[0][0].ToString()) >= (cupHeight.Value * cupWidth.Value / 100))
                    {
                        dtb = ConnectionClass.getResult("select min(Time) from ProvidersList where Material='" + cupMaterial.Text + "';");
                        MessageBox.Show("Price: " + p + "\r\nMin days: " + Convert.ToInt32(dtb.Rows[0][0].ToString()));
                    }
                    else
                    {
                        dtb = ConnectionClass.getResult("select min(Time) from ProvidersList where Material='" + doorMaterial.Text + "';");
                        int tmp = Convert.ToInt32(dtb.Rows[0][0].ToString());
                        dtb = ConnectionClass.getResult("select min(Time) from ProvidersList where Material='" + cupMaterial.Text + "';");
                        tmp = Math.Max(tmp, Convert.ToInt32(dtb.Rows[0][0].ToString()));
                        MessageBox.Show("Price: " + p + "\r\nMin days: " + tmp);
                    }
                }
            }
            else
            {
                product = new Table(tableType.Text, tableMaterial.Text, legNumber.Text, tableForm.Text, tableHeight.Text, tableWidth.Text);
                p = product.getPrice();
                ConnectionClass.executeQuery("insert into Products(Type ,Material,VolMaterial ,DopMaterial ,VolDopMaterial ,Price ,Status ,Image ) values ('"
                    + comboBox1.Text + "','" + tableMaterial.Text + "','" + (tableHeight.Value * tableWidth.Value / 10) + "',null,null,'" + p + "','" + "InStore" + "','" + "image" + "');");

                DataTable dtb = ConnectionClass.getResult("select Volume from Material where Name='" + tableMaterial.Text + "';");
                if (dtb.Rows.Count>0&&Convert.ToInt32(dtb.Rows[0][0].ToString()) >= (tableHeight.Value * tableWidth.Value / 10))
                    MessageBox.Show("Price: " + p);
                else
                {
                    dtb = ConnectionClass.getResult("select min(Time) from ProvidersList where Material='" + tableMaterial.Text + "';");
                    MessageBox.Show("Price: " + p + "\r\nMin days: " + Convert.ToInt32(dtb.Rows[0][0].ToString()));
                }
            }

            int clientID;
            DataTable dt = ConnectionClass.getResult(@"SELECT ID FROM Client where Login='" + clientId.Text + "';");
            clientID = Convert.ToInt32(dt.Rows[0][0]);

            dt = ConnectionClass.getResult
   (@"SELECT max(ID) FROM Products;");
            int nextID = Convert.ToInt32(dt.Rows[0][0]);

            ConnectionClass.executeQuery(@"INSERT INTO Orders(ClientID,ProductID,Price,Status,Data) 
VALUES(" + clientID + "," + nextID + "," + p + ",'InOrder','" + DateTime.Today.ToShortDateString() + "');");

            Close();
        }

        private void ChairType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChairType.Text == "Computer")
                chairForm.Enabled = false;
            else chairForm.Enabled = true;
        }

        private void tableType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableType.Text == "Computer")
                tableForm.Enabled = false;
            else tableForm.Enabled = true;
        }
    }
}
