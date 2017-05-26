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
   
    public partial class Providers : Form
    {
        public Providers()
        {
            InitializeComponent();

            updateTable();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ConnectionClass.getResult(@"SELECT * FROM ProvidersList where ProviderID = " + dataGridView1.SelectedRows[0].Cells[0].Value + ";");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProvider addProvider = new AddProvider();
            addProvider.ShowDialog();

            if (addProvider.DialogResult == DialogResult.OK)
            {

                //sql.Open();
                //SQLiteCommand sc = new SQLiteCommand
                   ConnectionClass.executeQuery (@"INSERT INTO Providers(Name,Address,Phone,Mail)  VALUES('" + addProvider.textBox1.Text + @"','" + addProvider.textBox2.Text + @"','" + addProvider.textBox3.Text + @"','" + addProvider.textBox4.Text + @"');");

                //sc.ExecuteNonQuery();


       //         sc = new SQLiteCommand
       //(@"SELECT max(ID) FROM Providers;", sql);

       //         SQLiteDataReader sdr = sc.ExecuteReader();
                DataTable dt = ConnectionClass.getResult(@"SELECT max(ID) FROM Providers;");
               // dt.Load(sdr);

                int maxID = Convert.ToInt32(dt.Rows[0][0]);
               // sdr.Close();
                                
                for (int i=0;i< addProvider.dataGridView1.Rows.Count-1; i++)
                {
                    ConnectionClass.executeQuery
                   (@"INSERT INTO ProvidersList(ProviderID,Material,Price,Volume,Time) 
                    VALUES(" + maxID + ",'" + addProvider.dataGridView1.Rows[i].Cells[0].Value + "',"
                    + addProvider.dataGridView1.Rows[i].Cells[1].Value + ","
                    + addProvider.dataGridView1.Rows[i].Cells[2].Value + ","
                    + addProvider.dataGridView1.Rows[i].Cells[3].Value 
                    + @");");

                    //sc.ExecuteNonQuery();
                    // textBox1.Text = dt.Rows[i][0] + " " + dt.Rows[i][1] + " " + dt.Rows[i][2] + " " + dt.Rows[i][3];
                }



                updateTable();

                //sql.Close();
            }
        }

        void updateTable()
        {
            dataGridView1.DataSource = ConnectionClass.getResult(@"SELECT * FROM Providers;");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ConnectionClass.getResult(@"SELECT * FROM ProvidersList;");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateTable();
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            BuyMaterials buymaterials = new BuyMaterials();
            buymaterials.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Purchases purchases = new Purchases();
            purchases.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reports.paymentsPdf(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
        }
    }
}
