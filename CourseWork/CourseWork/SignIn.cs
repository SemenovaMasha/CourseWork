using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace CourseWork
{
    public partial class SignIn : Form
    {
        SQLiteConnection sql;
        public SignIn()
        {
            InitializeComponent();
            sql = new SQLiteConnection(@"Data Source=D:\mydb.sqlite;Version=3");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sql.Open();
            //SQLiteCommand sc = new SQLiteCommand
            DataTable dt = ConnectionClass.getResult( @"SELECT * FROM Client where Login ='" + Login.Text + "' and Password='" + Password.Text + "';");

            //SQLiteDataReader sdr = sc.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(sdr);

            if (dt.Rows.Count > 0)
            {
                this.Visible = false;
                ConnectionClass.ID = Convert.ToInt32(dt.Rows[0][0].ToString());
                if (Convert.ToInt32(dt.Rows[0][0].ToString()) == 1)
                {
                    Admin a = new Admin();
                    a.ShowDialog();
                }
                else
                {
                    User u = new User();
                    u.ShowDialog();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Wrong!");
            }
            //sdr.Close();

            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SignUp signin = new SignUp();
            signin.ShowDialog();
            if (signin.DialogResult == DialogResult.OK)
            {
                //sql = new SQLiteConnection(@"Data Source=D:\mydb.sqlite;Version=3");

                //sql.Open();

                //SQLiteCommand sc = new SQLiteCommand
                        ConnectionClass.executeQuery(@"INSERT INTO Client(Name,Surname,Patronymic,Mail,Address,Phone,Login,Password)  
VALUES('" + signin.ClientName.Text + "','" + signin.Surname.Text + "','" + signin.Patronymic.Text + "','" + signin.Mail.Text + "','" + signin.Address.Text + "','" + signin.Phone.Text + "','" + signin.Login.Text + "','" + signin.Password.Text + "');");

                //sc.ExecuteNonQuery();
                //sql.Close();
            }

            this.Visible = true;
        }
    }
}
