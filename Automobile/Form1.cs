using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace Automobile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           webBrowser1.ScrollBarsEnabled = false;
            //webBrowser1.Document.BackColor = System.Drawing.Color.Transparent;
           webBrowser1.Navigate("http://www.uraaei.org/images/wheelspin04.gif");
            //progressBar1.Hide();
            //progressBar1.Maximum = 10000;
            //timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            //webBrowser1.ScrollBarsEnabled = false;
            //webBrowser1.Document.BackColor = System.Drawing.Color.Transparent;
            //webBrowser1.Navigate("http://www.uraaei.org/images/wheelspin04.gif");
            /*progressBar1.Show();
            for (int i = 0; i < 10000;i++ )
                loaderr();*/
            //Thread.Sleep(4000);
            for (int i = 0; i < 10000000; i++)
            { }
           Form2 ob = new Form2();
            this.Hide();
            ob.Show(); 
        }
        public void loaderr()
        {
            /*if (progressBar1.Value != 10000)
                progressBar1.Value += 1;*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // label1.Text = "Aman";
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
          
        }

        private void BG_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X + 7, label1.Location.Y);

            if (label1.Location.X > this.Width)
            {
                label1.Location = new Point(0 - label1.Width, label1.Location.Y);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("amanchopra64@gmail.com");
                mail.To.Add("amanchopra64@gmail.com");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("amanchopra64@gmail.com", "pleasebestrong");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            Form18 ob = new Form18();
            this.Hide();
            ob.Show();
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string to, message;
                //to = textBox1.Text;
                //message = textBox2.Text;
                //to = "8197974214";
                message = "Hi";

                string baseURL = "http://api.clickatell.com/http/sendmsg?user=amanchopra63&password=BFXETJdJPDAJPM&api_id=3598995&to=918197974214&text=Hi";
                client.OpenRead(baseURL);
                MessageBox.Show("Successfully sent message");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form19 ob = new Form19();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
