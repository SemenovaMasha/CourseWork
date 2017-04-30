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
    public partial class BuyMaterials : Form
    {
        public BuyMaterials()
        {
            InitializeComponent();

            DataTable dt =ConnectionClass.getResult
                  (@"SELECT distinct Material  FROM ProvidersList;"); 

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                materials.Items.Add(dt.Rows[i][0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = DateTime.Today.ToShortDateString();

            int price = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            
            ConnectionClass.executeQuery (@"INSERT INTO Purchase(ProviderID,Material,Volume,Price,Data) 
VALUES(" + dataGridView1.SelectedRows[0].Cells[1].Value + ",'" + dataGridView1.SelectedRows[0].Cells[2].Value + "'," + Volume.Value + ", " + price +",'"+data+"');");
          
            DataTable dt =   ConnectionClass.getResult
(@"SELECT * FROM Material where Name = '" + dataGridView1.SelectedRows[0].Cells[2].Value + "'; ");

            if (dt.Rows.Count == 1)
            {
                int old_Volume = Convert.ToInt32(dt.Rows[0][2]);
                ConnectionClass.executeQuery
             (@"update Material set Volume = " + (old_Volume + Convert.ToInt32(Volume.Value)) + " where Name = '" + dataGridView1.SelectedRows[0].Cells[2].Value + "';");
                
            }
            else
            {

               ConnectionClass.executeQuery
                (@"INSERT INTO Material(Name,Volume)  VALUES('" + dataGridView1.SelectedRows[0].Cells[2].Value + @"'," + Volume.Value + @");");
                

            }
          
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string searchMaterial = materials.Text;
            DataTable dt = ConnectionClass.getResult (@"SELECT *  FROM ProvidersList where Material = '"+ searchMaterial+"'; "); 
            dataGridView1.DataSource = dt;
            Volume.Value = 0;
            Volume.Increment = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Volume.Value = 0;
            Volume.Increment=Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
        }

        private void Volume_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
