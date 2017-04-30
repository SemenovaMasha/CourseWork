using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace CourseWork
{
    public partial class Store : Form
    {
        public Store()
        {

            InitializeComponent();
            
            DataTable dt = ConnectionClass.getResult(@"SELECT * FROM Material;");
            dataGridView1.DataSource = dt;

            
            comboBox1.Items.Add("Materials");
            comboBox1.Items.Add("Products");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMaterial addmaterial = new AddMaterial();
            addmaterial.ShowDialog();
            DataTable dt = ConnectionClass.getResult(@"SELECT * FROM Material;");
            dataGridView1.DataSource = dt;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Materials")
            {
                DataTable dt = ConnectionClass.getResult(@"SELECT * FROM Material;");
                dataGridView1.DataSource = dt;
                
            }
            else
            {
                dataGridView1.DataSource = ConnectionClass.getResult("select * from Products;");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();

      //      if (addProduct.DialogResult == DialogResult.OK)
      //      {
      //          Product product = addProduct.getProduct();
      //          string type;
      //          if (product is Chair)
      //          {
      //              type = "Chair";
      //          }
      //          else if (product is Cupboard)
      //          {
      //              type = "Cupboard";
      //          }
      //          else
      //          {
      //              type = "Desk";
      //          }

      //          sql = new SQLiteConnection(@"Data Source=D:\mydb.sqlite;Version=3");

      //          sql.Open();

      //          SQLiteCommand sc = new SQLiteCommand
      //                  (@"INSERT INTO ProductIDSeq(type) VALUES('"+type+"');", sql);
      //          sc.ExecuteNonQuery();

      //          sc = new SQLiteCommand
      //(@"SELECT max(ID) FROM ProductIDSeq;", sql);

      //          SQLiteDataReader sdr = sc.ExecuteReader();
      //          DataTable dt = new DataTable();
      //          dt.Load(sdr);
      //          textBox1.Text = dt.Rows.Count + "";
      //          int nextID = Convert.ToInt32(dt.Rows[0][0]);

      //          sdr.Close();

      //          //sc.ExecuteNonQuery();


               
      //          if (product is Chair)
      //          {
      //              Chair chair = (Chair)product;
      //              sc = new SQLiteCommand
      //              (@"INSERT INTO Chair VALUES(" + nextID + ",'" + chair.type + "','" + chair.material + "','" + chair.backForm + "'," + chair.backHeight + ",'InStore');", sql);
      //          }
      //          else if (product is Cupboard)
      //          {
      //              Cupboard cupboard = (Cupboard)product;
      //              sc = new SQLiteCommand
      //              (@"INSERT INTO Cupboard VALUES(" + nextID + ",'" + cupboard.type + "','" + cupboard.material + "'," + cupboard.height + "," + cupboard.width + ",'" + cupboard.doorMaterial + "'," + cupboard.shelf1 + "," + cupboard.shelf2 + ",'InStore');", sql);
      //          }
      //          else
      //          {
      //              Table table = (Table)product;
      //              sc = new SQLiteCommand
      //              (@"INSERT INTO Desk VALUES(" + nextID + ",'" + table.type + "','" + table.material + "'," + table.legNumber + ",'" + table.form + "'," + table.width + "," + table.height + ",'InStore');", sql);
      //          }
      //          sc.ExecuteNonQuery();

      //          sql.Close();

      //          comboBox1_SelectedIndexChanged(new object(), new EventArgs());
      //      }
        }
    }
}
