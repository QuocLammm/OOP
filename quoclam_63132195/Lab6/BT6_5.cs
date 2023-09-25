using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class BT6_5 : Form
    {
        public BT6_5()
        {
            InitializeComponent();
        }

        private void BT6_5_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            BT6_4 bt = new BT6_4();
            bt.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bài61ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 bt1 = new Form1();
            bt1.Show();
        }

        private void bài62ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BT6 bt2 = new BT6();
            bt2.Show();
        }

        private void bài63ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BT6_3 bt3 = new BT6_3();
            bt3.Show();
        }
    }
}
