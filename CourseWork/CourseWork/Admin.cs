using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.ShowDialog();
        }
        
        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Orders orders = new Orders();
            orders.ShowDialog();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Clients clients = new Clients();
            clients.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.ShowDialog();
        }

        private void providersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Providers providers = new Providers();
            providers.ShowDialog();
        }

        private void incomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(this.func1);
            myThread.Start();
        }

        private void expencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(this.func2);
            myThread.Start();
        }

        private void effectivenessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(this.func3); 
            myThread.Start();
        }
        void func1()
        {
            Reports.invoicesExcel(pictureBox1);
        }
        void func2()
        {
            Reports.expensesExcel(pictureBox1);
        }
        void func3()
        {
            Reports.effectExcel(pictureBox1);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Cursor Files|*.sqlite";
            od.Title = "Select a DataBase File";

            if (od.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               ConnectionClass.setConnectionString(od.FileName);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Cursor Files|*.sqlite";
            sd.Title = "Create a DataBase File";
            
            if (sd.ShowDialog() == System.Windows.Forms.DialogResult.OK&&sd.FileName != "")
            {
                ConnectionClass.createEmptyDataBase(sd.FileName.EndsWith(".sqlite")? sd.FileName: sd.FileName+".sqlite");
            }
        }

        private void sendToEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendToEmail se = new SendToEmail();
            se.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports.invoicesPdf();
        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.invoicesPdf();
        }
    }
}
