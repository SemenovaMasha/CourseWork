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
        
    }
}
