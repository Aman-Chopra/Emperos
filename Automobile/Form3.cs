using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Automobile
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
            //timer1.Start(); 
            //ptick();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            ptick();
            //label1.Left = label1.Left + 10;

        }
        public void ptick()
        {
            label1.Text = "Aman";
            label1.Location = new Point(label1.Location.X + 5, label1.Location.Y);

            if (label1.Location.X > this.Width)
            {
                label1.Location = new Point(0 - label1.Width, label1.Location.Y);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lname = textBox2.Text;
            string pno = textBox3.Text;
            string user = textBox4.Text;
            string pass = textBox5.Text;
            string email = textBox6.Text;
            

            try
            {

                


                if (name.Length == 0||lname.Length == 0||pno.Length == 0||user.Length == 0||pass.Length == 0)
                {
                    MessageBox.Show("Necessary fields are empty.\nPlease re-enter.");
                    return;
                }
                if(pno.Length!=10)
                {
                    MessageBox.Show("Phone number should be of ten digit.\nPlease re-enter.");
                    textBox3.Text = "";
                    return;
                }
                Boolean boole = true;
                foreach (char c in pno)
                {
                    if (c < '0' || c > '9')
                        boole = false;
                }
                if(boole==false)
                {
                    MessageBox.Show("Phone number should only contain digits.\nPlease re-enter.");
                    textBox3.Text = "";
                    return;
                }

                //Boolean check = MailAddress.MailAddress(email);

                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                { }
                else
                {
                    MessageBox.Show("E-mail ID is invalid.\nPlease re-enter.");
                    textBox6.Text = "";
                    return;
                }

                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Please select your Gender.");
                   // textBox6.Text = "";
                    return;
                }
                    

                int count = 0;
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "(SELECT COUNT(*) AS total FROM automobile.login where C_ID ='" + textBox4.Text + "');";// and Password = ' " + textBox2.Text + " ')";
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
                if (count != 0)
                {
                    MessageBox.Show("User name already exists.\nPlease choose another user name");
                    textBox4.Text = "";
                    return;
                }

                //textBox2.Text = count.ToString();
                MyConn2.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Congratulations. Your account has been successfully created");


         /*   Class1.Main(pass);
            string password = Class1.password1;
            MessageBox.Show(password);*/


            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into automobile.customer(C_ID,C_NAME,L_NAME,PH_NO,E_MAIL) values('" + user + "','" + name + "','" + lname + "','" + pno + "','" + email + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
               // MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Class1 ob = new Class1();
            string encryptedstring = ob.Encrypt(pass, "AGARAMUDHALA", "EZHUTHELLAM", "SHA1", 3, "@1B2c3D4e5F6g7H8", 256);


            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into automobile.login values('" + user + "','" + encryptedstring + "');";
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
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



          









            Form2 ob1 = new Form2();
            this.Hide();
            ob1.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
