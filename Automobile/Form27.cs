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
using MySql.Data.MySqlClient;


namespace Automobile
{
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //Display query  
                string Query = "select * from automobile.customer;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string to, message;
                to = textBox1.Text;
                //message = textBox2.Text;
                //to = "8197974214";
                message = "Hi";
                string baseURL = "http://api.clickatell.com/http/sendmsg?user=amanchopra63&password=BFXETJdJPDAJPM&api_id=3598995&to=8197974214&text=Hi";
          //      string baseURL = "http://api.clickatell.com/http/sendmsg?user=amanchopra63&password=BFXETJdJPDAJPM&api_id=3598995&to='"+to+"'&text=Hi";
                client.OpenRead(baseURL);
                MessageBox.Show("Successfully sent message");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 ob = new Form12();
            this.Hide();
            ob.Show();
        }
    }
}
