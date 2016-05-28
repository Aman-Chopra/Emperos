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
using System.Security.Cryptography;

namespace Automobile
{
    public partial class Form2 : Form
    {
        public static string id = "";
        public Form2()
        {
            InitializeComponent();
           /* var pos = this.PointToScreen(label1.Location);
            pos = pictureBox1.PointToClient(pos);
            label1.Parent = pictureBox1;
            label1.Location = pos;
            label1.BackColor = Color.Transparent;
            var pos2 = this.PointToScreen(label2.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            label2.Location = pos2;
            label2.BackColor = Color.Transparent;*/
            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

/*
            string s = "S1";
            int l = 0;
            


            try
            {


                int count = 0;
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms
                string pleasechalja = "Select automobile.calc_salary('" + s + "');";// and Password = ' " + textBox2.Text + " ')";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(pleasechalja, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                //MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                    l = MyReader2.GetInt32(0);
                }
                MessageBox.Show(l.ToString());               

                //textBox2.Text = count.ToString();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            */

           id = textBox1.Text;
            string password = textBox2.Text;


            if (id.Length == 0)
            {
                MessageBox.Show("Necessary fields are empty.\nPlease re-enter.");
                return;
            }
            if (password.Length == 0)
            {
                MessageBox.Show("Necessary fields are empty.\nPlease re-enter.");
                return;
            }


            //string pass = "";

            //MessageBox.Show(password);

          /*  try
            {


                int count = 0;
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "(SELECT Password FROM automobile.login where C_ID ='" + textBox1.Text +"');";// and Password = ' " + textBox2.Text + " ')";
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
                MessageBox.Show(pass);
               

                //textBox2.Text = count.ToString();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            Class1 ob = new Class1();
            string encryptedstring = ob.Encrypt(password, "AGARAMUDHALA", "EZHUTHELLAM", "SHA1", 3, "@1B2c3D4e5F6g7H8", 256);
            //MessageBox.Show(encryptedstring);
            //string decryptedstring = ob.Decrypt(encryptedstring, "AGARAMUDHALA", "EZHUTHELLAM", "SHA1", 3, "@1B2c3D4e5F6g7H8", 256);
            //MessageBox.Show(decryptedstring);
            try
            {


                int count = 0;
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "(SELECT COUNT(*) AS total FROM automobile.login where C_ID ='" + textBox1.Text + "' and Password='" + encryptedstring + "');";// and Password = ' " + textBox2.Text + " ')";
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
                    MessageBox.Show("Incorrect ID or Password");
                    return;
                }
                
                //textBox2.Text = count.ToString();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
            Form6 ob1 = new Form6();
            this.Hide();
            ob1.Show();
            
        }


        private void cUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dEALERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 ob = new Form4();
            this.Hide();
            ob.Show();
        }

        private void aDMINNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ob = new Form5();
            this.Hide();
            ob.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 ob = new Form3();
            this.Hide();
            ob.Show();
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 ob = new Form20();
            this.Hide();
            ob.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form22 ob = new Form22();
            this.Hide();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form19 ob = new Form19();
            this.Hide();
            ob.Show();
        }
    }

}
