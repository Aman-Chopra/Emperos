using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;

namespace Automobile
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length==0)
            {
                MessageBox.Show("Necessary fields are empty.\nPlease re-enter");
                return;
            }
            string id = textBox1.Text;

            try
            {
                int count = 0;
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "(SELECT COUNT(*) AS total FROM automobile.customer where C_ID ='" + id + "');";// and Password = ' " + textBox2.Text + " ')";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                //MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                    count = MyReader2.GetInt32("total");
                }
                if (count == 0)
                {
                    MessageBox.Show("User id does not exists.\nPlease re-enter");
                    textBox1.Text = "";
                    return;
                }

                //textBox2.Text = count.ToString();
                MyConn2.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string e_mail="";
            try
            {
                int count = 0;
                
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "(SELECT E_MAIL FROM automobile.customer where C_ID ='" + id + "');";// and Password = ' " + textBox2.Text + " ')";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                //MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                    e_mail = MyReader2.GetString("E_MAIL");
                }
               
                //textBox2.Text = count.ToString();
                MyConn2.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            string pass = "";
            try
            {
                int count = 0;

                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "(SELECT Password FROM automobile.login where C_ID ='" + id + "');";// and Password = ' " + textBox2.Text + " ')";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                //MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                    pass = MyReader2.GetString("Password");
                }

                //textBox2.Text = count.ToString();
                MyConn2.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            Class1 ob2 = new Class1();
            string decryptedstring = ob2.Decrypt(pass, "AGARAMUDHALA", "EZHUTHELLAM", "SHA1", 3, "@1B2c3D4e5F6g7H8", 256);














            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("amanchopra64@gmail.com");
                mail.To.Add(e_mail);
                mail.Subject = "Password Recovery";
                mail.Body = "Your password is " + decryptedstring;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("amanchopra64@gmail.com", "pleasebestrong");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No internet Connection");
                return;
            }
            Form2 ob = new Form2();
            this.Hide();
            ob.Show();


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            this.Hide();
            ob.Show();
        }
    }
}
