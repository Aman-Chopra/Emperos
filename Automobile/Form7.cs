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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            webBrowser1.ScrollBarsEnabled = false;
            //webBrowser1.Document.BackColor = System.Drawing.Color.Transparent;
            webBrowser1.Navigate("http://www.animationplayhouse.com/computerhelp.gif");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Item has been added to the database!!");

            string vid = textBox1.Text;
            double price=0;
            string model = "";
            try
            {
                int count = 0;

                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "(SELECT V_MODEL,V_PRICE FROM automobile.vehicles where V_ID ='" + vid + "');";// and Password = ' " + textBox2.Text + " ')";
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
                    model = MyReader2.GetString("V_MODEL");
                    price = MyReader2.GetDouble("V_PRICE");
                }
                

                //textBox2.Text = count.ToString();
                MyConn2.Close();
            }
            catch(Exception ex)
            {

            }






            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms  
                string a = "SA4";
                string show = "S1";
                string Query = "insert into automobile.sales values('" + a + "','" + vid + "','" + Form2.id + "','" + show + "'," + price + ",'" + model + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }







        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 ob = new Form6();
            this.Hide();
            ob.Show();
        }

        private void secondHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 ob = new Form8();
            this.Hide();
            ob.Show();
        }

        private void partsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 ob = new Form9();
            this.Hide();
            ob.Show();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 ob = new Form10();
            this.Hide();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Hide();
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //Display query  
                string Query = "select * from automobile.vehicles;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                DataSet dataset;
                dataset = new DataSet();
                MyAdapter.Fill(dataset);
                int t = dTable.Rows.Count;
                DataRow dr;
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Under Progress!");
            try
            {
                webBrowser1.Hide();
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //Display query  
                string Query = "select * from automobile.vehicles where V_PRICE>400000 and V_PRICE<600000;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                DataSet dataset;
                dataset = new DataSet();
                MyAdapter.Fill(dataset);
                int t = dTable.Rows.Count;
                DataRow dr;
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
