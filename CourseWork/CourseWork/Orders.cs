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
    public partial class Orders : Form
    {
        SQLiteConnection sql;
        public Orders()
        {
            InitializeComponent();
            displayOrders();
        }
        void displayOrders()
        {
            
            DataTable dt = ConnectionClass.getResult(@"SELECT Orders.ID,ClientID,ProductID,Products.Type,Products.Material,Products.Price,Orders.Status,Data 
FROM Orders,Products
where Products.ID=Orders.ProductID and Orders.Status='InOrder';");
            //SQLiteDataReader sdr = sc.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(sdr);

            dataGridView1.DataSource = dt;


            ////sdr.Close();

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (dt.Rows[i][3].ToString() == "Chair"|| dt.Rows[i][3].ToString() == "Table")
            //    {

            //        //DataTable dt5 = ConnectionClass.getResult(@"SELECT * FROM Products where ID=" + dataGridView1.Rows[i].Cells[2].Value + " ;");
                    
            //        //dataGridView1.Rows[i].Cells[4].Value = dt5.Rows[0][2].ToString();

            //        sc = new SQLiteCommand(@"SELECT * FROM Chair where ID=" + dataGridView1.Rows[i].Cells[2].Value + " ;", sql);
            //        sdr = sc.ExecuteReader();
            //        DataTable dt1 = new DataTable();
            //        dt1.Load(sdr);
            //        Chair chair = new Chair(dt1.Rows[0][1].ToString(), dt1.Rows[0][2].ToString(), dt1.Rows[0][3].ToString(), dt1.Rows[0][4].ToString());

            //        textBox1.Text = chair.type + " " + chair.material + " " + chair.backForm + " " + chair.backHeight;
            //        sc = new SQLiteCommand(@"SELECT * FROM Chair where Type='" + chair.type +
            //            "' and Material ='" + chair.material + "' and BackForm='" + chair.backForm +
            //            "' and BackHeight = " + chair.backHeight + " and Status = 'InStore';", sql);
            //        sdr = sc.ExecuteReader();

            //        dt1 = new DataTable();
            //        dt1.Load(sdr);
            //        if (dt1.Rows.Count > 0)
            //        {
            //            dataGridView1.Rows[i].Cells[6].Value = "ReadyInStore";
            //        }
            //        else
            //        {
            //            sc = new SQLiteCommand(@"SELECT * FROM Material where Name='" + chair.material + "' ;", sql);
            //            sdr = sc.ExecuteReader();
            //            DataTable dt2 = new DataTable();
            //            dt2.Load(sdr);
            //            if (dt2.Rows.Count > 0 && Convert.ToInt32(dt2.Rows[0][2].ToString()) > 100)
            //            {
            //                dataGridView1.Rows[i].Cells[6].Value = "ReadyToMake";
            //            }
            //            else
            //            {
            //                dataGridView1.Rows[i].Cells[6].Value = "NeedMaterial";

            //                sc = new SQLiteCommand(@"SELECT min(Time) FROM ProvidersList where Material='" + dataGridView1.Rows[i].Cells[4].Value + "' ;", sql);
            //                sdr = sc.ExecuteReader();
            //                DataTable dt6 = new DataTable();
            //                dt6.Load(sdr);
            //                dataGridView1.Rows[i].Cells[7].Value = dt6.Rows[0][0].ToString();
            //            }
            //        }




            //        sdr.Close();
            //    }
            //    else if (dt.Rows[i][3].ToString() == "Desk")
            //    {

            //        sc = new SQLiteCommand(@"SELECT * FROM Desk where ID=" + dataGridView1.Rows[i].Cells[2].Value + " ;", sql);
            //        sdr = sc.ExecuteReader();
            //        DataTable dt5 = new DataTable();
            //        dt5.Load(sdr);
            //        dataGridView1.Rows[i].Cells[4].Value = dt5.Rows[0][2].ToString();

            //        sc = new SQLiteCommand(@"SELECT * FROM Desk where ID=" + dataGridView1.Rows[i].Cells[2].Value + " ;", sql);
            //        sdr = sc.ExecuteReader();
            //        DataTable dt1 = new DataTable();
            //        dt1.Load(sdr);
            //        Table table = new Table(dt1.Rows[0][1].ToString(), dt1.Rows[0][2].ToString(), dt1.Rows[0][3].ToString(), dt1.Rows[0][4].ToString(), dt1.Rows[0][5].ToString(), dt1.Rows[0][6].ToString());

            //        // textBox1.Text = chair.type + " " + chair.material + " " + chair.backForm + " " + chair.backHeight;
            //        sc = new SQLiteCommand(@"SELECT * FROM Desk where Type='" + table.type +
            //            "' and Material ='" + table.material + "' and LegNumber=" + table.legNumber +
            //            " and Form = '" + table.form + "' and Width  =" + table.width +
            //            " and Height=" + table.height + " and Status = 'InStore';", sql);
            //        sdr = sc.ExecuteReader();

            //        dt1 = new DataTable();
            //        dt1.Load(sdr);
            //        if (dt1.Rows.Count > 0)
            //        {
            //            dataGridView1.Rows[i].Cells[6].Value = "ReadyInStore";
            //        }
            //        else
            //        {
            //            sc = new SQLiteCommand(@"SELECT * FROM Material where Name='" + table.material + "' ;", sql);
            //            sdr = sc.ExecuteReader();
            //            DataTable dt2 = new DataTable();
            //            dt2.Load(sdr);
            //            if (dt2.Rows.Count > 0 && Convert.ToInt32(dt2.Rows[0][2].ToString()) > 200)
            //            {
            //                dataGridView1.Rows[i].Cells[6].Value = "ReadyToMake";
            //            }
            //            else
            //            {
            //                dataGridView1.Rows[i].Cells[6].Value = "NeedMaterial";
            //                sc = new SQLiteCommand(@"SELECT min(Time) FROM ProvidersList where Material='" + dataGridView1.Rows[i].Cells[4].Value + "' ;", sql);
            //                sdr = sc.ExecuteReader();
            //                DataTable dt6 = new DataTable();
            //                dt6.Load(sdr);
            //                dataGridView1.Rows[i].Cells[7].Value = dt6.Rows[0][0].ToString();
            //            }
            //        }


            //        sdr.Close();
            //    }
            //    else
            //    {

            //        sc = new SQLiteCommand(@"SELECT * FROM Cupboard where ID=" + dataGridView1.Rows[i].Cells[2].Value + " ;", sql);
            //        sdr = sc.ExecuteReader();
            //        DataTable dt5 = new DataTable();
            //        dt5.Load(sdr);
            //        dataGridView1.Rows[i].Cells[4].Value = dt5.Rows[0][2].ToString();

            //        sc = new SQLiteCommand(@"SELECT * FROM Cupboard where ID=" + dataGridView1.Rows[i].Cells[2].Value + " ;", sql);
            //        sdr = sc.ExecuteReader();
            //        DataTable dt1 = new DataTable();
            //        dt1.Load(sdr);
            //        Cupboard cupboard = new Cupboard(dt1.Rows[0][1].ToString(), dt1.Rows[0][2].ToString(), dt1.Rows[0][3].ToString(), dt1.Rows[0][4].ToString(), dt1.Rows[0][5].ToString(), dt1.Rows[0][6].ToString(), dt1.Rows[0][7].ToString());

            //        // textBox1.Text = chair.type + " " + chair.material + " " + chair.backForm + " " + chair.backHeight;
            //        sc = new SQLiteCommand(@"SELECT * FROM Cupboard where Type='" + cupboard.type +
            //            "' and Material ='" + cupboard.material + "' and Height=" + cupboard.height +
            //            " and Width = " + cupboard.width + " and DoorMaterial  ='" + cupboard.doorMaterial +
            //            "' and ShelfNumber1=" + cupboard.shelf1 + " and ShelfNumber2=" + cupboard.shelf2 +
            //            " and Status = 'InStore';", sql);
            //        sdr = sc.ExecuteReader();

            //        dt1 = new DataTable();
            //        dt1.Load(sdr);
            //        if (dt1.Rows.Count > 0)
            //        {
            //            dataGridView1.Rows[i].Cells[6].Value = "ReadyInStore";
            //        }
            //        else
            //        {
            //            sc = new SQLiteCommand(@"SELECT * FROM Material where Name='" + cupboard.material + "' ;", sql);
            //            sdr = sc.ExecuteReader();
            //            DataTable dt2 = new DataTable();
            //            dt2.Load(sdr);
            //            sc = new SQLiteCommand(@"SELECT * FROM Material where Name='" + cupboard.doorMaterial + "' ;", sql);
            //            sdr = sc.ExecuteReader();
            //            DataTable dt3 = new DataTable();
            //            dt3.Load(sdr);
            //            if (dt2.Rows.Count > 0 && Convert.ToInt32(dt2.Rows[0][2].ToString()) > 400 && Convert.ToInt32(dt3.Rows[0][2].ToString()) > 50)
            //            {
            //                dataGridView1.Rows[i].Cells[6].Value = "ReadyToMake";
            //            }
            //            else
            //            {
            //                dataGridView1.Rows[i].Cells[6].Value = "NeedMaterial";
            //                sc = new SQLiteCommand(@"SELECT min(Time) FROM ProvidersList where Material='" + dataGridView1.Rows[i].Cells[4].Value + "' ;", sql);
            //                sdr = sc.ExecuteReader();
            //                DataTable dt6 = new DataTable();
            //                dt6.Load(sdr);
            //                dataGridView1.Rows[i].Cells[7].Value = dt6.Rows[0][0].ToString();
            //            }
            //        }


            //        //        sdr.Close();
            //        //    }


            //        sql.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool canBeMade = true;
            //sql.Open();
            int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);

            //SQLiteCommand sc = new SQLiteCommand
            //          (@"update Chair set Status='InStore' where ID=" + ID + ";", sql);
            //sc.ExecuteNonQuery();

            //DataTable dt=ConnectionClass.getResult(@"SELECT * FROM Material where Name='" + dataGridView1.SelectedRows[0].Cells[4].Value + "' ;");
            
            //int oldValue = Convert.ToInt32(dt.Rows[0][2].ToString());
            //oldValue -= 100;
            //sc = new SQLiteCommand
            //       (@"update Material set Volume=" + oldValue + " where Name='" + dataGridView1.SelectedRows[0].Cells[4].Value + "';", sql);
            //sc.ExecuteNonQuery();


            DataTable product = ConnectionClass.getResult(@"SELECT * FROM Products where ID='" + dataGridView1.SelectedRows[0].Cells[2].Value + "' ;");
            DataTable dt = ConnectionClass.getResult(@"SELECT * FROM Material where Name='" + product.Rows[0][2].ToString() + "' ;");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Not enough material1");
                return;

            }
            int oldValue = Convert.ToInt32(dt.Rows[0][2].ToString());

            //oldValue -= 100;
            if (oldValue < Convert.ToInt32(product.Rows[0][3].ToString())) canBeMade = false;
            int oldValue2=0;
            if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "Cupboard")
            {
                dt = ConnectionClass.getResult(@"SELECT * FROM Material where Name='" + product.Rows[0][4].ToString() + "' ;");
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Not enough material2"+ product.Rows[0][4].ToString());
                    return;

                }
                oldValue2 = Convert.ToInt32(dt.Rows[0][2].ToString());
                //oldValue2 -= 100;
                if (oldValue2 < Convert.ToInt32(product.Rows[0][5].ToString())) canBeMade = false;
            }

            if (!canBeMade)
            {
                MessageBox.Show("Not enough material3");
                return;
            }

            oldValue -= Convert.ToInt32(product.Rows[0][3].ToString());
            ConnectionClass.executeQuery(@"update Material set Volume=" + oldValue + " where Name='" + product.Rows[0][2].ToString() + "';");
            if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "Cupboard")
            {
                oldValue2 -= Convert.ToInt32(product.Rows[0][5].ToString());
                ConnectionClass.executeQuery(@"update Material set Volume=" + oldValue + " where Name='" + product.Rows[0][4].ToString() + "';");

            }
            ConnectionClass.executeQuery(@"update Products set Status='Sold' where ID=" + ID + ";");

            ConnectionClass.executeQuery(@"update Orders set Status='Sold', Data='" +  DateTime.Today.ToShortDateString() +"' where ProductID=" + ID + ";");
            ConnectionClass.executeQuery("insert into Sales(ClientID ,ProductID ,Price ,Data) values ("+ dataGridView1.SelectedRows[0].Cells[1].Value +
                "," + dataGridView1.SelectedRows[0].Cells[2].Value +"," + dataGridView1.SelectedRows[0].Cells[5].Value +",'" + DateTime.Today.ToShortDateString() + "');");

            //if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "Chair")
            //{
            //    SQLiteCommand sc = new SQLiteCommand
            //            (@"update Chair set Status='InStore' where ID=" + ID + ";", sql);
            //sc.ExecuteNonQuery();

            //    sc = new SQLiteCommand(@"SELECT * FROM Material where Name='" + dataGridView1.SelectedRows[0].Cells[4].Value + "' ;", sql);
            //    SQLiteDataReader sdr = sc.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    dt.Load(sdr);
            //    int oldValue = Convert.ToInt32(dt.Rows[0][2].ToString());
            //    oldValue -= 100;
            //    sc = new SQLiteCommand
            //           (@"update Material set Volume="+oldValue+" where Name='" + dataGridView1.SelectedRows[0].Cells[4].Value + "';", sql);
            //    sc.ExecuteNonQuery();

            //}
            //else if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "Desk")
            //{
            //    SQLiteCommand sc = new SQLiteCommand
            //            (@"update Desk set Status='InStore' where ID=" + ID + ";", sql);
            //    sc.ExecuteNonQuery();
            //    sc = new SQLiteCommand(@"SELECT * FROM Material where Name='" + dataGridView1.SelectedRows[0].Cells[4].Value + "' ;", sql);
            //    SQLiteDataReader sdr = sc.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    dt.Load(sdr);
            //    int oldValue = Convert.ToInt32(dt.Rows[0][2].ToString());
            //    oldValue -= 200;
            //    sc = new SQLiteCommand
            //           (@"update Material set Volume=" + oldValue + " where Name='" + dataGridView1.SelectedRows[0].Cells[4].Value + "';", sql);
            //    sc.ExecuteNonQuery();

            //}
            //else
            //{
            //    SQLiteCommand sc = new SQLiteCommand
            //            (@"update Cupboard set Status='InStore' where ID=" + ID + ";", sql);
            //    sc.ExecuteNonQuery();

            //    sc = new SQLiteCommand(@"SELECT * FROM Material where Name='" + dataGridView1.SelectedRows[0].Cells[4].Value + "' ;", sql);
            //    SQLiteDataReader sdr = sc.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    dt.Load(sdr);
            //    int oldValue = Convert.ToInt32(dt.Rows[0][2].ToString());
            //    oldValue -= 400;
            //    sc = new SQLiteCommand
            //           (@"update Material set Volume=" + oldValue + " where Name='" + dataGridView1.SelectedRows[0].Cells[4].Value + "';", sql);
            //    sc.ExecuteNonQuery();

            //    sc = new SQLiteCommand(@"SELECT * FROM Cupboard where ID=" + ID + ";", sql);
            //    sdr = sc.ExecuteReader();
            //    dt = new DataTable();
            //    dt.Load(sdr);
            //    string doorMaterial = dt.Rows[0][5].ToString();

            //    sc = new SQLiteCommand(@"SELECT * FROM Material where Name='" +doorMaterial+ "' ;", sql);
            //    sdr = sc.ExecuteReader();
            //    dt = new DataTable();
            //    dt.Load(sdr);
            //    oldValue = Convert.ToInt32(dt.Rows[0][2].ToString());
            //    oldValue -= 50;
            //    sc = new SQLiteCommand
            //           (@"update Material set Volume=" + oldValue + " where Name='" + doorMaterial + "';", sql);
            //    sc.ExecuteNonQuery();

            //    sql.Close();
            //}
            displayOrders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql.Open();
            int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);

            if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "Chair")
            {
                SQLiteCommand sc = new SQLiteCommand
                          (@"update Chair set Status='Sold' where ID=" + ID + ";", sql);
                sc.ExecuteNonQuery();

                sc = new SQLiteCommand
                          (@"delete  from Orders where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value + ";", sql);
                sc.ExecuteNonQuery();

                string data = DateTime.Today.ToShortDateString();
                sc = new SQLiteCommand
                          (@"insert  into Sales(ClientID,ProductID,Price,Data) values(" 
+ dataGridView1.SelectedRows[0].Cells[1].Value + "," + dataGridView1.SelectedRows[0].Cells[2].Value + "," + dataGridView1.SelectedRows[0].Cells[5].Value +",'"+data +"');", sql);
                sc.ExecuteNonQuery();


            }
            else if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "Desk")
            {

                SQLiteCommand sc = new SQLiteCommand
                          (@"update Desk set Status='Sold' where ID=" + ID + ";", sql);
                sc.ExecuteNonQuery();

                sc = new SQLiteCommand
                          (@"delete  from Orders where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value + ";", sql);
                sc.ExecuteNonQuery();

                string data = DateTime.Today.ToShortDateString();
                sc = new SQLiteCommand
                          (@"insert  into Sales(ClientID,ProductID,Price,Data) values("
+ dataGridView1.SelectedRows[0].Cells[1].Value + "," + dataGridView1.SelectedRows[0].Cells[2].Value + "," + dataGridView1.SelectedRows[0].Cells[5].Value + ",'" + data + "');", sql);
                sc.ExecuteNonQuery();
            }
            else
            {
                SQLiteCommand sc = new SQLiteCommand
                          (@"update Cupboard set Status='Sold' where ID=" + ID + ";", sql);
                sc.ExecuteNonQuery();

                sc = new SQLiteCommand
                          (@"delete  from Orders where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value + ";", sql);
                sc.ExecuteNonQuery();

                string data = DateTime.Today.ToShortDateString();
                sc = new SQLiteCommand
                          (@"insert  into Sales(ClientID,ProductID,Price,Data) values("
+ dataGridView1.SelectedRows[0].Cells[1].Value + "," + dataGridView1.SelectedRows[0].Cells[2].Value + "," + dataGridView1.SelectedRows[0].Cells[5].Value + ",'" + data + "');", sql);
                sc.ExecuteNonQuery();

            }

            sql.Close();
            displayOrders();
        }
    }
}
