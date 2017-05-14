using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

            reDraw(null,null);

            comboBox1.SelectedIndexChanged += reDraw;
            chairForm.SelectedIndexChanged += reDraw;
            ChairType.SelectedIndexChanged += reDraw;
            chairHeight.ValueChanged += reDraw;
            cupHeight.ValueChanged += reDraw;
            cupType.SelectedIndexChanged += reDraw;
            cupWidth.ValueChanged += reDraw;
            shelfNum.ValueChanged += reDraw;
            tableForm.SelectedIndexChanged += reDraw;
            tableHeight.ValueChanged += reDraw;
            tableWidth.ValueChanged += reDraw;
            legNumber.ValueChanged += reDraw;
            tableType.SelectedIndexChanged += reDraw;

            comboBox1.SelectedIndex = 2;
            tableType.SelectedIndex = 1;

            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        void reDraw(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            draw(g);
            pictureBox1.Image = bmp;
        }

        void draw(Graphics g)
        {
            g.FillRectangle(Brushes.White, 0, 0, 500, 500);

            if (comboBox1.SelectedIndex == 0)
            {
                if (ChairType.SelectedIndex == 0)
                {
                    int h = Convert.ToInt32(chairHeight.Value);
                    Pen p = new Pen(Color.FromArgb(200, 100, 100));
                    g.DrawArc(p, 100, 200 - h, 100, 200, 180, 180);
                    g.DrawLine(p, 100, 300 - h, 200, 300 - h);
                    g.DrawRectangle(p, 140, 300 - h, 20, h / 3);
                    g.DrawEllipse(p, 80, 300 - 2 * h / 3, 140, 50);
                    g.DrawRectangle(p, 145, 350 - 2 * h / 3, 10, 2 * h / 3);
                    g.DrawLine(p, 150, 350, 120, 340);
                    g.DrawEllipse(p, 112, 340, 15, 15);
                    g.DrawLine(p, 150, 350, 100, 360);
                    g.DrawEllipse(p, 92, 360, 15, 15);
                    g.DrawLine(p, 150, 350, 145, 380);
                    g.DrawEllipse(p, 137, 380, 15, 15);
                    g.DrawLine(p, 150, 350, 200, 360);
                    g.DrawEllipse(p, 192, 360, 15, 15);
                    g.DrawLine(p, 150, 350, 180, 335);
                    g.DrawEllipse(p, 172, 335, 15, 15);
                }
                else
                {
                    if (chairForm.SelectedIndex == 0)
                    {
                        int h = Convert.ToInt32(chairHeight.Value);
                        Pen p = new Pen(Color.FromArgb(200, 100, 100));
                        g.DrawLine(p, 100, 200 - h, 250, 190 - h);
                        g.DrawLine(p, 250, 310 - h / 2, 250, 190 - h);
                        g.DrawLine(p, 100, 200 - h, 120, 330 - h / 2);
                        g.DrawLine(p, 250, 280 - h / 2, 120, 300 - h / 2);

                        g.DrawLine(p, 120, 330 - h / 2, 250, 310 - h / 2);
                        g.DrawLine(p, 320, 340 - h / 2, 250, 310 - h / 2);
                        g.DrawLine(p, 320, 340 - h / 2, 190, 360 - h / 2);
                        g.DrawLine(p, 120, 330 - h / 2, 190, 360 - h / 2);

                        g.DrawLine(p, 120, 330 - h / 2, 120, 380);
                        g.DrawLine(p, 190, 360 - h / 2, 190, 410);
                        g.DrawLine(p, 320, 340 - h / 2, 320, 390);
                        g.DrawLine(p, 250, 350 - h / 2, 250, 360);
                    }
                    else
                    {
                        int h = Convert.ToInt32(chairHeight.Value);
                        Pen p = new Pen(Color.FromArgb(200, 100, 100));
                        g.DrawArc(p, 120, 160 - h, 120, 200 + h / 2, 120, 295);

                        g.DrawLine(p, 120, 330 - h / 2, 120, 380);
                        g.DrawLine(p, 190, 350 - h / 2, 190, 410);
                        g.DrawLine(p, 320, 330 - h / 2, 320, 390);
                        g.DrawLine(p, 250, 350 - h / 2, 250, 360);

                        g.DrawEllipse(p, 120, 300 - h / 2, 200, 50);
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                    int h = Convert.ToInt32(cupHeight.Value);
                    int w = Convert.ToInt32(cupWidth.Value);
                    int shn = Convert.ToInt32(shelfNum.Value);
                    Pen p = new Pen(Color.FromArgb(200, 100, 100));

                    g.DrawRectangle(p, 80, 50, w*3/2,h*5/2);
                    g.DrawLine(p, 80, 50, 110, 30);
                    g.DrawLine(p, 110 + w * 3 / 2, 30, 110, 30);
                    g.DrawLine(p, 110 + w * 3 / 2, 30, 80 + w * 3 / 2, 50);
                    g.DrawLine(p, 110 + w * 3 / 2, 30, 110 + w * 3 / 2, 30 + h * 5 / 2);
                    g.DrawLine(p, 80 + w * 3 / 2, 50 + h * 5 / 2, 110 + w * 3 / 2, 30 + h * 5 / 2);

                    //p = new Pen(Color.FromArgb(255, 200, 100));
                for (int i = 0; i < shn; i++)
                {
                    g.DrawRectangle(p, 80,  10+h * 5 / 2-i*40, w * 3 / 2, 40);
                    g.DrawEllipse(p, 70 + w * 3 / 4, 10 + h * 5 / 2 - i * 40 + 15, 10, 10);
                }

                g.DrawLine(p, 80 + w * 3 / 4, 50, 80 + w * 3 / 4, 50 + h * 5 / 2 - shn * 40);
                if (cupType.SelectedIndex == 1)
                {
                    g.DrawEllipse(p, 60 + w * 3 / 4, 50 + h * 5 / 4 - shn * 20, 10, 10);
                    g.DrawEllipse(p, 90 + w * 3 / 4, 50 + h * 5 / 4 - shn * 20, 10, 10);
                }
            }else{                
                int h = Convert.ToInt32(tableHeight.Value);
                int w = Convert.ToInt32(tableWidth.Value);
            
                Pen p = new Pen(Color.FromArgb(200, 100, 100));

                if (tableType.SelectedIndex == 0)
                {
                    g.DrawLine(p, 20, 300 - h, 50, 320 - h);
                    g.DrawLine(p, 20, 300 - h, 20, 370);
                    g.DrawLine(p, 50, 390, 20, 370);
                    g.DrawLine(p, 50, 390, 50, 320 - h);

                    g.DrawLine(p, 230 + w, 320 - h, 50, 320 - h);
                    g.DrawLine(p, 20, 300 - h, 200 + w, 300 - h);
                    g.DrawLine(p, 230 + w, 320 - h, 200 + w, 300 - h);
                    g.DrawLine(p, 230 + w, 320 - h, 230 + w, 390);
                    g.DrawLine(p, 150 + w, 390, 230 + w, 390);
                    g.DrawLine(p, 150 + w, 390, 150 + w, 320 - h);
                    g.DrawLine(p, 150 + w, 390, 120 + w, 370);
                    g.DrawLine(p, 120 + w, 320 - h, 120 + w, 370);
                    g.DrawLine(p, 50, 370, 120 + w, 370);

                    g.DrawLine(p, 230 + w, 390, 200 + w, 370);
                    g.DrawLine(p, 150 + w, 370, 200 + w, 370);
                    g.DrawLine(p, 200 + w, 320 - h, 200 + w, 370);
                }
                else
                {
                    int l = Convert.ToInt32(legNumber.Value);
                    if (tableForm.SelectedIndex == 1)
                    {
                        g.DrawLine(p, 20, 310 - h, 70, 270 - h);//
                        g.DrawLine(p, 230 + w, 270 - h, 70, 270 - h);
                        g.DrawLine(p, 230 + w, 270 - h, 180 + w, 310 - h);
                        g.DrawLine(p, 20, 310 - h, 180 + w, 310 - h);
                        if (l == 4)
                        {
                            g.DrawLine(p, 20, 310 - h, 20, 370);
                            g.DrawLine(p, 180 + w, 370, 180 + w, 310 - h);
                            g.DrawLine(p, 230 + w, 270 - h, 230 + w, 330);
                            g.DrawLine(p, 70, 310 - h, 70, 330);
                        }
                        else
                        {
                            g.DrawLine(p, 110 + w / 2, 330, 110 + w / 2, 310 - h);
                            g.DrawEllipse(p, 100 + w / 2, 327, 20, 7);
                        }
                    }
                    else
                    {
                        g.DrawEllipse(p, 0, 248 - h, 240 + w, 70);

                        if (l == 4)
                        {
                            g.DrawLine(p, 20, 300 - h, 20, 370);
                            g.DrawLine(p, 180 + w, 370, 180 + w, 310 - h);
                            g.DrawLine(p, 230 + w, 295 - h, 230 + w, 330);
                            g.DrawLine(p, 70, 310 - h, 70, 330);
                        }
                        else
                        {
                            g.DrawLine(p, 110 + w / 2, 330, 110 + w / 2, 320 - h);
                            g.DrawEllipse(p, 100 + w / 2, 327, 20, 7);
                        }
                    }

                }
            }
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
                    + comboBox1.Text + "','" + chairMaterial.Text + "','" + chairHeight.Value + "',null,null,'" +p + "','" + "InStore" + "','" + getBytes()+ "');");
                
                DataTable dtb = ConnectionClass.getResult("select Volume from Material where Name='"+chairMaterial.Text+"';");
                if (dtb.Rows.Count > 0 &&Convert.ToInt32(dtb.Rows[0][0].ToString()) >= Convert.ToInt32(chairHeight.Text))
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
                    + comboBox1.Text + "','" + cupMaterial.Text + "','" + (cupHeight.Value*cupWidth.Value/10) + "','" + doorMaterial.Text + "','" + (cupHeight.Value * cupWidth.Value / 100) + "','" + p + "','" + "InStore" + "','" + getBytes() + "');");

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
                    + comboBox1.Text + "','" + tableMaterial.Text + "','" + (tableHeight.Value * tableWidth.Value / 10) + "',null,null,'" + p + "','" + "InStore" + "','" + getBytes() + "');");

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
            {
                tableForm.Enabled = false;
                legNumber.Enabled = false;
            }
            else
            {
                tableForm.Enabled = true;
                legNumber.Enabled = true;
            }
        }

        string getBytes()
        {
            string bitmapString = null;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                pictureBox1.Image.Save(memoryStream, ImageFormat.Png);
                byte[] bitmapBytes = memoryStream.GetBuffer();
                bitmapString = Convert.ToBase64String(bitmapBytes, Base64FormattingOptions.InsertLineBreaks);
            }
            MessageBox.Show(bitmapString.Length+"");
            return bitmapString;
        }
    }
}
