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
using MySql.Data.MySqlClient;

namespace Automobile
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
        }

        public void sup()
        {
            //webBrowser1.ScrollBarsEnabled = false;
            //webBrowser1.Document.BackColor = System.Drawing.Color.Transparent;
            //webBrowser1.Navigate("http://www.uraaei.org/images/wheelspin04.gif");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            /*webBrowser1.ScrollBarsEnabled = false;
            //webBrowser1.Document.BackColor = System.Drawing.Color.Transparent;
            webBrowser1.Navigate("http://www.uraaei.org/images/wheelspin04.gif");*/
            //Thread.Sleep(2000);
            Form1 ob = new Form1();
            this.Hide();
            ob.Show();

            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 ob = new Form6();
            this.Hide();
            ob.Show();
        }

        private void brandNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 ob = new Form7();
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

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
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
           MessageBox.Show("Under Progress");
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //Display query  
                string Query = "select * from automobile.vehicles where co;";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
    }
}
