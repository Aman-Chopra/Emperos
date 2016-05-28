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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void brandNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 ob = new Form7();
            this.Hide();
            ob.Show();
        }

        private void secondHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 ob = new Form8();
            this.Hide();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 ob = new Form6();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //Display query  
                string Query = "select * from automobile.parts;";
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

        }
    }
}
