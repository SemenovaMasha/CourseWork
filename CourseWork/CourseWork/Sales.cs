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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();

            dataGridView1.DataSource = ConnectionClass.getResult("SELECT Orders.ID, Client.Login, " +
                "ProductID, Products.Type, Products.Material, Products.Price, Orders.Status , Orders.Data" +
                " FROM Orders, Products,Client where Products.ID = Orders.ProductID and Orders.Status = 'Sold' and Orders.ClientID=Client.ID; ");

            //dataGridView1.DataSource = ConnectionClass.getResult("SELECT Sales.ID, Client.Login, " +
            //    "ProductID, Products.Type, Products.Material, Sales.Price,  Sales.Data" +
            //    " FROM  Sales,Products,Client where Products.ID = Sales.ProductID and Sales.ClientID=Client.ID; ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports.sellsPdf();
        }
    }
}
