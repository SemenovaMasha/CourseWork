using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CourseWork
{
    public partial class User : Form
    {
        SQLiteConnection sql;
        public User()
        {
            InitializeComponent();
            sql = new SQLiteConnection(@"Data Source=D:\mydb.sqlite;Version=3");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderCon order = new OrderCon();
            order.ShowDialog();

//            if (order.DialogResult == DialogResult.OK)
//            {
//                Product product = order.getProduct();
//                string type;
//                if (product is Chair)
//                {
//                    type = "Chair";
//                }
//                else if (product is Cupboard)
//                {
//                    type = "Cupboard";
//                }
//                else
//                {
//                    type = "Desk";
//                }

//                sql = new SQLiteConnection(@"Data Source=D:\mydb.sqlite;Version=3");

//                sql.Open();

//                SQLiteCommand sc = new SQLiteCommand
//                    (@"INSERT INTO ProductIDSeq(type) VALUES('" + type + "');", sql);
//                sc.ExecuteNonQuery();

//                sc = new SQLiteCommand
//      (@"SELECT max(ID) FROM ProductIDSeq;", sql);

//                SQLiteDataReader sdr = sc.ExecuteReader();
//                DataTable dt = new DataTable();
//                dt.Load(sdr);
//                int nextID = Convert.ToInt32(dt.Rows[0][0]);

//                sdr.Close();

//                sc.ExecuteNonQuery();


//                if (product is Chair)
//                {
//                    Chair chair = (Chair)product;
//                    sc = new SQLiteCommand
//                    (@"INSERT INTO Chair VALUES(" + nextID + ",'" + chair.type + "','" + chair.material + "','" + chair.backForm + "'," + chair.backHeight + ",'InOrder');", sql);
//                }
//                else if (product is Cupboard)
//                {
//                    Cupboard cupboard = (Cupboard)product;
//                    sc = new SQLiteCommand
//                    (@"INSERT INTO Cupboard VALUES(" + nextID + ",'" + cupboard.type + "','" + cupboard.material + "'," + cupboard.height + "," + cupboard.width + ",'" + cupboard.doorMaterial + "'," + cupboard.shelf1 + "," + cupboard.shelf2 + ",'InOrder');", sql);
//                }
//                else
//                {
//                    Table table = (Table)product;
//                    sc = new SQLiteCommand
//                    (@"INSERT INTO Desk VALUES(" + nextID + ",'" + table.type + "','" + table.material + "'," + table.legNumber + ",'" + table.form + "'," + table.width + "," + table.height + ",'InOrder');", sql);
//                }
//                sc.ExecuteNonQuery();


//                int clientId;
//                sc = new SQLiteCommand
//                     (@"SELECT ID FROM Client where Login='" + order.clientId.Text + "';", sql);

//                sdr = sc.ExecuteReader();
//                dt = new DataTable();
//                dt.Load(sdr);

//                clientId = Convert.ToInt32(dt.Rows[0][0]);

//                sdr.Close();

//                sc = new SQLiteCommand
//                    (@"INSERT INTO Orders(ClientID,ProductID,Price) 
//VALUES(" + clientId + "," + nextID + ",300);", sql);

//                sc.ExecuteNonQuery();
//                sql.Close();
//            }
        }
        

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderCon order = new OrderCon();
            order.ShowDialog();
        }

        private void myOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ConnectionClass.getResult("select * from Orders where ClientID=" + ConnectionClass.ID + ";");
        }
    }
}
