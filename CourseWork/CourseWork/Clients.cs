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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            DataTable dt = ConnectionClass.getResult(@"SELECT * FROM Client;");
            dataGridView1.DataSource = dt;
        }
    }
}
