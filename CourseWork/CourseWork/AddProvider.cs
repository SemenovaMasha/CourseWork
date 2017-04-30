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
    public partial class AddProvider : Form
    {
        public AddProvider()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionClass.executeQuery(
            @"INSERT INTO Providers(Name,Address,Phone,Mail)  VALUES('" + textBox1.Text + @"','" + textBox2.Text + @"','" + textBox3.Text + @"','" + textBox4.Text + @"');");


            DataTable dt = ConnectionClass.getResult(@"SELECT max(ID) FROM Providers;");

            int maxID = Convert.ToInt32(dt.Rows[0][0]);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                ConnectionClass.executeQuery
               (@"INSERT INTO ProvidersList(ProviderID,Material,Price,Volume,Time) 
                    VALUES(" + maxID + ",'" + dataGridView1.Rows[i].Cells[0].Value + "',"
                + dataGridView1.Rows[i].Cells[1].Value + ","
                + dataGridView1.Rows[i].Cells[2].Value + ","
                + dataGridView1.Rows[i].Cells[3].Value
                + @");");

            }



            Close();
        }
    }
}
