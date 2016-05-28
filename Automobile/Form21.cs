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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (selected == "Gearonics")
            {
                webBrowser1.Navigate("https://www.google.co.in/maps/place/Manipal,+Karnataka+576104/@13.3460067,74.7746656,14z/data=!3m1!4b1!4m2!3m1!1s0x3bbca35639f9cc91:0xc9e04ffb553340fc");
            }
            else if (selected == "Meteora")
                webBrowser1.Navigate("https://www.google.co.in/maps?biw=1366&bih=667&q=google+map+of+maihar&bav=on.2,or.r_cp.&bvm=bv.119745492,d.c2E&um=1&ie=UTF-8&sa=X&ved=0ahUKEwjJ99fChKjMAhVMCo4KHcauBXIQ_AUIBigB");
            else
                MessageBox.Show("Please select one of our Showrooms");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            this.Hide();
            ob.Show();
        }

    }
}
