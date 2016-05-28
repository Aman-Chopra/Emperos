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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
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
                Form13 ob = new Form13();
                ob.dataGridView1.DataSource = dTable;
                this.Hide();
                ob.Show();// here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
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
                Form16 ob = new Form16();
                ob.dataGridView1.DataSource = dTable;
                this.Hide();
                ob.Show();// here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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
                Form15 ob = new Form15();
                ob.dataGridView1.DataSource = dTable;
                this.Hide();
                ob.Show();// here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void seeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
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
                Form14 ob = new Form14();
                ob.dataGridView1.DataSource = dTable;
                this.Hide();
                ob.Show();// here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dealersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Under Construction");
        }

        private void secondHandCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
              //MessageBox.Show("Under Construction");
        }

        private void partsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Under Construction");
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Under Construction");
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Under Construction");
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Under Construction");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form5 ob = new Form5();
            this.Hide();
            ob.Show();
        }

        private void insertToolStripMenuItem2_Click(object sender, EventArgs e)
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
                Form13 ob = new Form13();
                ob.dataGridView1.DataSource = dTable;
                this.Hide();
                ob.Show();// here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
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
                Form13 ob = new Form13();
                ob.dataGridView1.DataSource = dTable;
                this.Hide();
                ob.Show();// here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
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
                Form13 ob = new Form13();
                ob.dataGridView1.DataSource = dTable;
                this.Hide();
                ob.Show();// here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void seeDatabaseToolStripMenuItem2_Click(object sender, EventArgs e)
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
                Form13 ob = new Form13();
                ob.dataGridView1.DataSource = dTable;
                this.Hide();
                ob.Show();// here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void seeDatabaseToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //Display query  
                string Query = "select * from automobile.servicing;";
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
                Form23 ob = new Form23();
                ob.dataGridView1.DataSource = dTable;
                this.Hide();
                ob.Show();// here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

           

        }

        private void updateSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //Display query  
                string Query = "select * from automobile.workers;";
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
                Form24 ob = new Form24();
                ob.dataGridView1.DataSource = dTable;
                this.Hide();
                ob.Show();// here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void checkProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form26 ob = new Form26();
            this.Hide();
            ob.Show();











        }

        private void specialCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string le = "";
            try
            {


                int count = 0;
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms
                string pleasechalja = "select C_NAME FROM CUSTOMER C WHERE NOT EXISTS (SELECT SH_ID FROM SHOWROOM WHERE SH_ID=S1 EXCEPT SELECT SH_ID FROM SALES S WHERE C.C_ID=S.C_ID";// and Password = ' " + textBox2.Text + " ')";
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
                    le = MyReader2.GetString("C_NAME");
                }
                MessageBox.Show(le);

                //textBox2.Text = count.ToString();
                MyConn2.Close();
            }




































            catch (Exception ex)
            {
                MessageBox.Show("Suvimal");
            }
        }

        private void addDealersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form28 ob = new Form28();
            this.Hide();
            ob.Show();
        }

        private void sendMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form27 ob = new Form27();
            this.Hide();
            ob.Show();
        }

        private void allCustomerNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String l = "";
            try
            {


                int count = 0;
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms
                string pleasechalja = "call automobile.curs();";// and Password = ' " + textBox2.Text + " ')";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(pleasechalja, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                //MessageBox.Show("Save Data");
                int i = 0;
                while (MyReader2.Read())
                {
                    l = MyReader2.GetString(i);
                    MessageBox.Show(l);
                    i++;
                }
                // MessageBox.Show("Salary = " + l.ToString());

                //textBox2.Text = count.ToString();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
