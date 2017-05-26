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
    public partial class AddMaterial : Form
    {
        public AddMaterial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = ConnectionClass.getResult(@"SELECT * FROM Material where Name = '" + textBox1.Text + "'; ");
                if (dt.Rows.Count == 1)
                {
                    int old_Volume = Convert.ToInt32(dt.Rows[0][2]);
                ConnectionClass.executeQuery
                 (@"update Material set Volume = " + (old_Volume + Convert.ToInt32(textBox2.Text)) + " where Name = '" + textBox1.Text + "';");
                
                }
                else
                {
                ConnectionClass.executeQuery
                    (@"INSERT INTO Material(Name,Volume)  VALUES('" + textBox1.Text + @"'," + textBox2.Text + @");");
                }
            
            Close();
        }
    }
}
