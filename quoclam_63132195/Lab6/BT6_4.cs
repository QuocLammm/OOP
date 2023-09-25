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
    public partial class BT6_4 : Form
    {
        List<User> ds;
        public BT6_4()
        {
            InitializeComponent();
            ds = new List<User>();
            Read_File();
            MessageBox.Show(ds.Count.ToString());
        }
        void Read_File()
        {
            try
            {
                FileStream f = new FileStream("E:\\HĐT\\quoclam_63132195\\Lab6\\User.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(f);
                string line;//luu du lieu doc tung dong tu file ra chuong trinh
                while ((line = rd.ReadLine()) != null)//con dong du lieu trong file
                {
                    string[] item = line.Split(';');//2 phan tu trong item
                    string m = item[0];
                    string t = item[1];
                    User s = new User(m, t);
                    ds.Add(s);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);

            }
        }
        private void BT6_4_Load(object sender, EventArgs e)
        {

        }
        //phương thức xử lý sự kiện nút Login
        private void btnL_Click(object sender, EventArgs e)
        {
            //tìm trong list xem có user có tên = text trong txtus không, kết quả tìm kiếm trả về trong u1, nếu u1 = null nghĩa là không có username trong list
            //u2 lưu kết quả tìm đối tượng có password = txtpw trong list
            User u1 = ds.Find(s => s.Name == txtus.Text);
            User u2 = ds.Find(s => s.Pass == txtpw.Text);

            if (u1 != null) //nếu có user thỏa mãn username
            {
                if (u2 != null) //nếu có user thỏa mãn password
                {
                    MessageBox.Show("Logged in successfully!");
                    Close();
                }
                else //nếu không có user thỏa mãn password
                   if (MessageBox.Show("Invalid password!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txtpw.Clear();
                    txtpw.Focus();
                }
                else
                    Application.Exit();
            }
            else //nếu không có user thỏa mãn username
                if (MessageBox.Show("Invalid username!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                txtus.Clear();
                txtus.Focus();
            }
            else
                Application.Exit();
        }
        private void bntClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    class User
    {
        string name, mk;
        public User(string n = "", string p = "")
        {
            name = n; mk = p;
        }
        public string Pass { get => mk; set => mk = value; }
        public string Name { get => name; set => name = value; }
    }

}
