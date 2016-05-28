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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void whatWeDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 ob = new Form18();
            this.Hide();
            ob.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form21 ob = new Form21();
            this.Hide();
            ob.Show();
        }
    }
}
