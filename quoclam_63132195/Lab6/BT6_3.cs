using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class BT6_3 : Form
    {
        List<Phone> ds;
        string pic;//duong dan toi 1 hinh anh
        public BT6_3()
        {
            InitializeComponent();
        }
        //doc file
        void Read_File()
        {
            try
            {
                FileStream f = new FileStream("E:\\HĐT\\quoclam_63132195\\Lab6\\Phone.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(f);
                string line;//luu du lieu doc tung dong tu file ra chuong trinh               

                while ((line = rd.ReadLine()) != null)//con dong du lieu trong file
                {
                    string[] item = line.Split(';');//4 phan tu trong item
                    string m = item[0];//ma
                    string h = item[1];//nhan hieu
                    float p = float.Parse(item[2]);//gia nhap
                    string pic = item[3];//duong dan toi file hinh
                    Phone phone = new Phone(m, h, p, pic);
                    ds.Add(phone);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        private void BT6_3_Load(object sender, EventArgs e)
        {
            ds = new List<Phone>();
            Read_File();
            dgvDSDT.DataSource = ds;

        }

        private void btnT_Click(object sender, EventArgs e)
        {
            string m = txtms.Text;
            string h = cbbnh.Text;
            float gn = float.Parse(txtgn.Text);
            Phone p = new Phone(m, h, gn, pic);
            ds.Add(p);
            dgvDSDT.DataSource = null;
            dgvDSDT.DataSource = ds;

        }

        

        private void btnX_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < ds.Count; i++)
                if (txtms.Text == ds[i].Id)
                    break;
            if (i < ds.Count)
            {
                ds.RemoveAt(i);
                txtms.Clear();
                dgvDSDT.DataSource = null;
                dgvDSDT.DataSource = ds;
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Phone ph = ds.Find(p => p.Id == txtms.Text);
            if (ph != null)
                txtgb.Text = ph.Sale().ToString();
        }

        private void btnsx_Click(object sender, EventArgs e)
        {
            ds.Sort();
            dgvDSDT.DataSource = null;
            dgvDSDT.DataSource = ds;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picDT_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic = ofd.FileName;
                picDT.Image = Image.FromFile(pic);
            }
        }
    }
}
