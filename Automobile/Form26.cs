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

namespace Automobile
{
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 ob = new Form12();
            this.Hide();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string s = textBox1.Text;
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
                MessageBox.Show("Salary = "+l.ToString());

                //textBox2.Text = count.ToString();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }







            string si = textBox1.Text;
            int li = 0;
            try
            {


                int count = 0;
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms
                string pleasechalja = "Select automobile.calc_sales('" + si + "');";// and Password = ' " + textBox2.Text + " ')";
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
                    li = MyReader2.GetInt32(0);
                }
                MessageBox.Show("Sales = "+li.ToString());

                //textBox2.Text = count.ToString();
                MyConn2.Close();
                int ans = li - l;
                MessageBox.Show("Profit = " + ans.ToString());
                Form12 ob = new Form12();
                this.Hide();
                ob.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
    }
}
