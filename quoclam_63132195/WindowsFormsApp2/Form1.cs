using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(txta.Text);
            b = int.Parse(txtb.Text);
            if (a == 0)
                if (b == 0)
                    txtketqua.Text = "Phuong trinh vo so nghiem";
                else
                    txtketqua.Text = "Pt vo nghiem";
            else
            {
                float x = (float)-b / a;
                txtketqua.Text = "Pt co nghiem la: x=" + x;
            }
        }
    }
}
