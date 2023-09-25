using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class MonHoc
    {
        string mamh;
        string tenmh;
        int dvht;// đơn vị học trình
        float tlkt;//tỉ lệ thi giữa kỳ
        float dkt;// điểm kiểm tra
        float tlgk;
        float dgk;// điểm giữa kỳ
        float dt;// điểm thi
        private string ms;
        private string hoten;
        private DateTime ns;
        private string dt1;

        public MonHoc()
        {
            mamh = "ST01";
            tenmh = "Cơ sở dữ liệu";
            dvht = 4;
            tlkt = 0.2f;
            dkt = 8.5f;
            tlgk = 0.3f;
            dgk = 9.2f;
            dt = 7;
        }
        public MonHoc(string m, string t, int sotc, float tlkt, float dkt, float tlgk, float dgk, float dt)
        {
            mamh = m;
            tenmh = t;
            dvht = sotc;
            this.tlkt = tlkt;
            this.dkt = dkt;
            this.tlgk = tlgk;
            this.dgk = dgk;
            this.dt = dt;
        }

        public MonHoc(string ms, string hoten, DateTime ns, string dt1)
        {
            this.ms = ms;
            this.hoten = hoten;
            this.ns = ns;
            this.dt1 = dt1;
        }

        public int Sotc { get => dvht; set => dvht = value; }
        public float Dthi { get => dt; set => dt = value; }
        // Nhập thông tin
        public void Set()
        {
            Console.Write("Nhập mã môn học:");
            mamh = Console.ReadLine();
            Console.Write("Nhập tên môn học:");
            tenmh = Console.ReadLine();
            Console.Write("Nhập số đơn vị học trình: ");
            dvht = int.Parse(Console.ReadLine());
            Console.Write("Nhập tỷ lệ kiểm tra: ");
            tlkt = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm kiểm tra: ");
            dkt = float.Parse(Console.ReadLine());
            Console.Write("Nhập tỷ lệ thi giữa kỳ: ");
            tlgk = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm thi giữa kỳ: ");
            dgk = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm thi: ");
            dt = float.Parse(Console.ReadLine());
        }
        // Phương thức tính điểm trung bình môn học
        public double Average()
        {
            return tlkt * dkt + tlgk * dgk + (1 - tlkt - tlgk) * dt;
        }
        // Xuất thông tin
        public void Print()
        {
            Console.WriteLine($"Tên môn học:{tenmh}");
            Console.WriteLine($"Điểm kiểm tra:{dkt}");
            Console.WriteLine($"Điểm thi giữa kỳ:{dgk}");
            Console.WriteLine($"Điểm thi:{dt}");
            Console.WriteLine($"Điểm trung bình:{Average()}");
        }
        //kiem tra du lieu doc file
        public void Print_F()
        {
            Console.WriteLine($"{mamh}\t{tenmh}\t{dvht}\t{tlkt}\t{dkt}\t{tlgk}\t{dgk}\t{dt}");
        }
    }
    class SinhVien
    {
        string mssv;
        string hoten;
        List<MonHoc> DSMH;
        // Khởi tạo
        public SinhVien()
        {
            mssv = "63132195";
            hoten = "Cao Nguyễn Quốc Lâm";
            DSMH = new List<MonHoc>();
        }
        // Nhập thông tin
        void ReadFile()
        {
            try
            {
                FileStream f = new FileStream("D:\\HĐT\\quoclam_63132195\\Monhoc.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(f);
                string line;//luu du lieu doc tung dong tu file ra chuong trinh
                while ((line = rd.ReadLine()) != null)//con dong du lieu trong file
                {
                    string[] item = line.Split(';');//8 phan tu trong item
                    string m = item[0];
                    string t = item[1];
                    byte sotc = byte.Parse(item[2]);
                    float tlkt = float.Parse(item[3]);
                    float dkt = float.Parse(item[4]);
                    float tlgk = float.Parse(item[5]);
                    float dgk = float.Parse(item[6]);
                    float dt = float.Parse(item[7]);
                    MonHoc mh = new MonHoc(m, t, sotc, tlkt, dkt, tlgk, dgk, dt);
                    DSMH.Add(mh);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
        public void Set()
        {
            Console.Write("Nhập mã số sinh viên:");
            mssv = Console.ReadLine();
            Console.Write("Nhập họ và tên:");
            hoten = Console.ReadLine();
            //nhap danh sach cac mon hoc
            DSMH = new List<MonHoc>();
            //nhap danh sach mon hoc: doc du lieu tu file
            ReadFile();
        }
        public float AverageHK()
        {
            float s = 0;
            int tc = 0;
            foreach (MonHoc mh in DSMH)
            {
                s = (float)(s + mh.Average() * mh.Sotc);
                tc = tc + mh.Sotc;
            }
            return s / tc;
        }
        public bool HocBong()
        {
            foreach (MonHoc monHoc in DSMH)
            {
                if (monHoc.Average() < 5.5)
                {
                    return false;
                }
            }
            return AverageHK() > 7;
        }

        public void Print()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mã số sinh viên: " + mssv);
            Console.WriteLine("Họ tên sinh viên: " + hoten);
            foreach (MonHoc monHoc in DSMH)
                monHoc.Print_F();
            Console.WriteLine("Điểm trung bình học kỳ: " + AverageHK());
        }
    }
}
