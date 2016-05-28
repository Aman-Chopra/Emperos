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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void gearonicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 ob = new Form7();
            this.Hide();
            ob.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            this.Hide();
            ob.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            this.Hide();
            ob.Show();
        }

        private void meteroraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Same as Gearonics!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=aman";
                string Query = "delete from automobile.customer where C_ID='" + Form2.id + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form19 ob = new Form19();
            this.Hide();
            ob.Show();
        }
    }
}
