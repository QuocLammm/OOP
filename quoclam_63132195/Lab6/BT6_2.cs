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
    public partial class BT6 : Form
    {
        public BT6()
        {
            InitializeComponent();
        }
        private void BT6_Load(object sender, EventArgs e)
        {
            rbtn1.Checked = true; //hiển thị forrm mặc định rdbPTB1 được chọn
        }

        private void btnTH_Click_1(object sender, EventArgs e)
        {
            float a, b, c;
                if (rbtn1.Checked)//PTB1
                {
                    a = float.Parse(txta.Text);
                    b = float.Parse(txtb.Text);
                    PTB1 pt1 = new PTB1(a, b);
                    txtkq.Text = pt1.Giai_WF();
                }
                if (rbtn2.Checked)//PTB2
                {
                    a = float.Parse(txta.Text);
                    b = float.Parse(txtb.Text);
                    c = float.Parse(txtc.Text);
                    PTB2 pt2 = new PTB2(a, b, c);
                    txtkq.Text = pt2.Giai_WF();
                }
        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn2.Checked)
                txtc.Enabled = true;
            else
                txtc.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal class PTB1
        {
            protected float b, c;//bx+c=0
                                 //Khởi tạo
            public PTB1(float b = 0, float c = 0)
            {
                this.b = b; this.c = c;
            }
            //dung cho ung dung WF
            public string Giai_WF()
            {
                if (b == 0)
                    if (c == 0)
                        return "Phương trình vô số nghiệm!";
                    else
                        return "Phương trình vô nghiệm!";
                else
                {
                    float x = -c / b;
                    return "Phương trình có nghiệm x=" + x;
                }
            }
        }
        class PTB2 : PTB1
        {
            float a;//ax^2+bx+c=0
            public PTB2(float a = 0, float b = 0, float c = 0) : base(b, c)
            {
                this.a = a;
            }
            //dung cho ung dung WF
            public new string Giai_WF()
            {
                if (a == 0)
                    return base.Giai_WF();
                else
                {
                    float del = b * b - (4 * a * c);
                    if (del < 0)
                        return "Phương trình vô nghiệm!";
                    else if (del == 0)
                    {
                        float x = -b / (2 * a);
                        return "Phương trình có nghiệm kép x1 = x2 = " + x;
                    }
                    else
                    {
                        float x1 = (-b - (float)Math.Sqrt(del)) / (2 * a);
                        float x2 = (-b + (float)Math.Sqrt(del)) / (2 * a);
                        return "Phương trình có 2 nghiệm phân biệt x1 = " + x1 + ",x2= " + x2;
                    }
                }
            }
        }

            private void txtkq_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT6_Load_1(object sender, EventArgs e)
        {

        }
    }
}
