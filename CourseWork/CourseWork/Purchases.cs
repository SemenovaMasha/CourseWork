﻿using System;
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
    public partial class Purchases : Form
    {
        public Purchases()
        {
            InitializeComponent();
          
            DataTable dt =   ConnectionClass.getResult (@"SELECT * FROM Purchase;");

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports.invoicesPdf();
        }
    }
}
