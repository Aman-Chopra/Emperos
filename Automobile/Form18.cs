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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
           /* axWindowsMediaPlayer1.path =
    @"https://www.youtube.com/watch?v=KRaPZkSJOvc";*/
        }

        private void developersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState.ToString().Equals("wmppsPlaying"))
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            Form20 ob = new Form20();
            this.Hide();
            ob.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState.ToString().Equals("wmppsPlaying"))
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            Form21 ob = new Form21();
            this.Hide();
            ob.Show();
        }
    }
}
