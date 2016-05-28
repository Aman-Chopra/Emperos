using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 ob = new Form4();
            this.Hide();
            ob.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form4 ob = new Form4();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cars are added to the database");


        }
    }
}
