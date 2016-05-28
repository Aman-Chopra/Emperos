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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void partsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 ob = new Form9();
            this.Hide();
            ob.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 ob = new Form6();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                //This is my insert query in which i am taking input from the user through windows forms
                String msgid = textBox1.Text;
                string Query = "(SELECT COST AS total FROM automobile.servicing where V_MODEL= '" + msgid + "');";
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
                textBox2.Text = count.ToString();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
    }
}
