using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Order : Form
    {
        
        public Order()
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
            legNumber.Items.Add("1");
            legNumber.Items.Add("3");
            legNumber.Items.Add("4");
                        
            //sql = new SQLiteConnection(@"Data Source=D:\mydb.sqlite;Version=3");

            //sql.Open();
            //SQLiteCommand sc = new SQLiteCommand
            //      (@"SELECT Login FROM Client;", sql);

            //SQLiteDataReader sdr = sc.ExecuteReader();
            DataTable dt = ConnectionClass.getResult(@"SELECT Login FROM Client;");
            //dt.Load(sdr);
            
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                clientId.Items.Add(dt.Rows[i][0]);
            }
            //sdr.Close();

            //sql.Close();

        }        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Chair")
            {
                groupBox1.Left = 20;
                groupBox3.Left = 400;
                Cupboard.Left = 400;

            }else if (comboBox1.Text=="Table")
            {
                groupBox1.Left = 400;
                groupBox3.Left = 20;
                Cupboard.Left = 400;
            }
            else
            {
                groupBox1.Left = 400;
                groupBox3.Left = 400;
                Cupboard.Left = 20;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    if (comboBox1.SelectedIndex == 0)
            //    {
            //        product = new Chair(ChairType.Text, chairMaterial.Text, chairForm.Text, chairHeight.Text);
            //    }
            //    else if (comboBox1.SelectedIndex == 1)
            //    {
            //        product = new Cupboard(cupType.Text, cupMaterial.Text, cupHeight.Text, cupWidth.Text, DoorMaterial.Text, shelf1.Text, shelf2.Text);
            //    }
            //    else
            //    {
            //        product = new Table(tableType.Text, tableMaterial.Text, legNumber.Text, tableForm.Text, tableHeight.Text, tableWidth.Text);
            //    }

            if (comboBox1.SelectedIndex == 0)
            {
                 product = new Chair(ChairType.Text, chairMaterial.Text, chairForm.Text, chairHeight.Text);

                ConnectionClass.executeQuery("insert into Products(Type ,Material,VolMaterial ,DopMaterial ,VolDopMaterial ,Price ,Status ,Image ) values ('"
                    + comboBox1.Text + "','" + chairMaterial.Text + "','" + "100" + "',null,null,'" + "200" + "','" + "InStore" + "','" + "image" + "');");


            }
            else if (comboBox1.SelectedIndex == 1)
            {
                // product = new Cupboard(cupType.Text, cupMaterial.Text, cupHeight.Text, cupWidth.Text, DoorMaterial.Text, shelf1.Text, shelf2.Text);
                ConnectionClass.executeQuery("insert into Products(Type ,Material,VolMaterial ,DopMaterial ,VolDopMaterial ,Price ,Status ,Image ) values ('"
                    + comboBox1.Text + "','" + cupMaterial.Text + "','" + "300" + "','" + DoorMaterial.Text + "','" + "100" + "','" + "500" + "','" + "InStore" + "','" + "image" + "');");

            }
            else
            {
                //product = new Table(tableType.Text, tableMaterial.Text, legNumber.Text, tableForm.Text, tableHeight.Text, tableWidth.Text);
                ConnectionClass.executeQuery("insert into Products(Type ,Material,VolMaterial ,DopMaterial ,VolDopMaterial ,Price ,Status ,Image ) values ('"
                    + comboBox1.Text + "','" + tableMaterial.Text + "','" + "200" + "',null,null,'" + "300" + "','" + "InStore" + "','" + "image" + "');");

            }

            int clientID;
            DataTable dt =ConnectionClass.getResult(@"SELECT ID FROM Client where Login='" + clientId.Text + "';"); 
            clientID = Convert.ToInt32(dt.Rows[0][0]);

           dt= ConnectionClass.getResult
  (@"SELECT max(ID) FROM Products;");
            int nextID = Convert.ToInt32(dt.Rows[0][0]);

            ConnectionClass.executeQuery(@"INSERT INTO Orders(ClientID,ProductID,Price,Status,Data) 
VALUES(" + clientID + "," + nextID + ","+"300"+",'InOrder','" + DateTime.Today.ToShortDateString()+"');");
            
            Close();
        }
        public Product getProduct()
        {
            return product;
        }
        Product product;

    }
}
