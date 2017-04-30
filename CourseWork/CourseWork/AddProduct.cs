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
    public partial class AddProduct : Form
    {
        public AddProduct()
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
            if (comboBox1.SelectedIndex == 0)
            {
                // product = new Chair(ChairType.Text, chairMaterial.Text, chairForm.Text, chairHeight.Text);
                ConnectionClass.executeQuery("insert into Products(Type ,Material,VolMaterial ,DopMaterial ,VolDopMaterial ,Price ,Status ,Image ) values ('"
                    + comboBox1.Text + "','" + chairMaterial.Text + "','" + "100" + "',null,null,'" + "200" + "','" + "InStore" + "','" + "image" + "');");


            }
            else if (comboBox1.SelectedIndex == 1)
            {
               // product = new Cupboard(cupType.Text, cupMaterial.Text, cupHeight.Text, cupWidth.Text, DoorMaterial.Text, shelf1.Text, shelf2.Text);
                ConnectionClass.executeQuery("insert into Products(Type ,Material,VolMaterial ,DopMaterial ,VolDopMaterial ,Price ,Status ,Image ) values ('"
                    + comboBox1.Text + "','" + cupMaterial.Text + "','" + "300" + "','" + DoorMaterial + "','"+ "100" + "','" + "500" + "','" + "InStore" + "','" + "image" + "');");

            }
            else
            {
                //product = new Table(tableType.Text, tableMaterial.Text, legNumber.Text, tableForm.Text, tableHeight.Text, tableWidth.Text);
                ConnectionClass.executeQuery("insert into Products(Type ,Material,VolMaterial ,DopMaterial ,VolDopMaterial ,Price ,Status ,Image ) values ('"
                    + comboBox1.Text + "','" + tableMaterial.Text + "','" + "200" + "',null,null,'" + "300" + "','" + "InStore" + "','" + "image" + "');");

            }

            Close();
        }
        public Product getProduct()
        {
            return product;
        }
        Product product;

    }
}
