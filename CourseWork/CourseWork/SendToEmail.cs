using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;


namespace CourseWork
{
    public partial class SendToEmail : Form
    {
        public SendToEmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName != "")
            {
                label1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 25);
            
            Smtp.Credentials = new NetworkCredential("semenovamasha98@mail.ru", "qwe098qwe");
            
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("semenovamasha98@mail.ru");
            Message.To.Add(new MailAddress(textBox1.Text));
            Message.Subject = "Report";
            Message.Body = textBox2.Text;
            
            string file = label1.Text;
            Attachment attach = new Attachment(file, MediaTypeNames.Application.Octet);
            Message.Attachments.Add(attach);
            
            Smtp.EnableSsl = true;
            Smtp.Send(Message);

        }
    }
}
