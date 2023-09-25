using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextForm
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string a; 
            string b;
            a=Convert.ToString(txtten.Text);
            a = Convert.ToString(txtten.Text);
            if (a == "lam123") {
                if (b == "000")
                {
                    MessageBox.Show("Dang nhap thanh cong!", "thong bao", MessageBoxButton.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sai mat khau!", "thong bao", MessageBoxButton.OK,
                    MessageBoxIcon.Information);
                }
            else
                {
                    MessageBox.Show("Sai Ten va ma khau!", "thong bao", MessageBoxButton.OK,
                    MessageBoxIcon.Information);
                }
            }
        }
    }
}
