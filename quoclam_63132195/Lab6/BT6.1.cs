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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Phép cộng
        private void btnS_Click_1(object sender, EventArgs e)
        {
            float a, b;
            bool chka = float.TryParse(txta.Text, out a);
            if (!chka)
                if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txta.Clear();//xoa dư lieu trong txta
                    txta.Focus();//đưa con trỏ tới txta
                }
            bool chkb = float.TryParse(txtb.Text, out b);
            if (!chkb)
                if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtb.Clear();//xoa dư lieu trong txtb
                    txtb.Focus();//đưa con trỏ tới txtb
                }
            txtkq.Text = (a + b).ToString();

        }
        // Phép trừ
        private void btnD_Click(object sender, EventArgs e)
        {

            float a, b;
            bool chka = float.TryParse(txta.Text, out a);
            if (!chka)
                if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txta.Clear();//xoa dư lieu trong txta
                    txta.Focus();//đưa con trỏ tới txta
                }
            bool chkb = float.TryParse(txtb.Text, out b);
            if (!chkb)
                if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtb.Clear();//xoa dư lieu trong txtb
                    txtb.Focus();//đưa con trỏ tới txtb
                }
            txtkq.Text = (a - b).ToString();

        }
        // Phép nhân
        private void btnM_Click(object sender, EventArgs e)
        {
            float a, b;
            bool chka = float.TryParse(txta.Text, out a);
            if (!chka)
                if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txta.Clear();//xoa dư lieu trong txta
                    txta.Focus();//đưa con trỏ tới txta
                }
            bool chkb = float.TryParse(txtb.Text, out b);
            if (!chkb)
                if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtb.Clear();//xoa dư lieu trong txtb
                    txtb.Focus();//đưa con trỏ tới txtb
                }
            txtkq.Text = (a * b).ToString();

        }
        // Phép chia
        private void btnA_Click(object sender, EventArgs e)
        {
            float a, b;
            bool chka = float.TryParse(txta.Text, out a);
            if (!chka)
                if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txta.Clear();//xoa dư lieu trong txta
                    txta.Focus();//đưa con trỏ tới txta
                }
            bool chkb = float.TryParse(txtb.Text, out b);
            if (!chkb)
                if (MessageBox.Show("Lỗi định dạng\nBạn có muốn nhập lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtb.Clear();//xoa dư lieu trong txtb
                    txtb.Focus();//đưa con trỏ tới txtb
                }
            txtkq.Text = (a / b).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncl_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //xóa dữ liệu trong textbox số a, b, ket qua
            txta.Text = "";
            txtb.Clear();
            txtkq.Clear();
        }



    }
}
