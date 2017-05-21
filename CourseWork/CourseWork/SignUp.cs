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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ConnectionClass.executeQuery("insert into Client( Name , Surname ,Patronymic ,Mail ,Address ,Phone ,Login ,Password )" +
                " values('"+ClientName.Text+"','"+Surname.Text + "','" + Patronymic.Text + "','" + Mail.Text + "','" + Address.Text + "','" + Phone.Text + "','" + Login.Text + "','" + Password.Text+"') ");
            Close();
        }
    }
}
