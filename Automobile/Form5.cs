﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="Aman"||textBox2.Text!="Aman")
            {
                MessageBox.Show("User-ID or Password is wrong.\nPlease re-enter.");
                return;
            }
            Form12 ob = new Form12();
            this.Hide();
            ob.Show();
        }
    }
}
