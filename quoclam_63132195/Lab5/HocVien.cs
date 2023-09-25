using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public interface IHocPhi
    {
        decimal TienHP { get; set; }
        decimal TT();//phương thức tính tiền giảm học phí dựa trên đối tượng.
    }
    class HocVien : IHocPhi,IComparable<HocVien>
    {
        public int ms { get; set; }
        public string hoten { get; set; }
        public string dt { get; set; }// mã số, họ tên và đối tượng
        public string ngaysinh { get; set; }

        public decimal TienHP { get; set; }
        public HocVien()
        {
        }
        public HocVien(int m, string h, string n, string d,decimal thp)
        {
            ms= m;
            hoten= h;
            ngaysinh= n;
            dt= d;
            TienHP = thp;
        }
        public void Set()
        {
            Console.Write("Nhập mã số học viên: ");
            ms = int.Parse(Console.ReadLine());
            Console.Write("Nhập họ tên học viên: ");
            hoten = Console.ReadLine();
            Console.Write("Nhập ngày sinh (dd-mm-yyyy): ");
            ngaysinh = Console.ReadLine();
            Console.Write("Nhập đối tượng (SV1 || SV2): ");
            dt = Console.ReadLine();
            Console.Write("Nhập tiền học phí: ");
            TienHP = decimal.Parse(Console.ReadLine());
        }
        // Phương thức Tostring() xuất thông tinn
        public override string ToString()
        {
            return $"Mã số: {ms}, Họ tên: {hoten}, Ngày sinh: {ngaysinh}, Đối tượng: {dt}, Tiền học phí: {TienHP}, Tổng tiền học phí phải trả:{TT()}";
        }
        public decimal TienGiam()
        {
            if (dt == "SV1") return TienHP * 0.1m;// giảm 10%
            else return TienHP * 0.2m;
        }
        public decimal TT()
        {
            return TienHP - TienGiam();
        }
        // Sắp xếp học viên theo thứ tự giảm dần của học phí
        public int CompareTo(HocVien other)
        {
            return other.TienHP.CompareTo(TienHP);
        }
        //kiem tra du lieu doc file
        public void Print_F()
        {
            Console.WriteLine($"{ms}\t {hoten}\t{ngaysinh}\t{dt}\t{TienHP}\tTổng tiền học phí được giảm :{TT()}");
        }
    }
    class KhoaHoc
    {
        string TenKH { get; set; }
        public int SLHocVien { get; set; }
        public object TienHP { get; set; }

        private List<HocVien> hocvien = new List<HocVien>();

        // Phương thức khởi tạo
        public KhoaHoc()
        {
            hocvien = new List<HocVien>();
        }
        // Phương thức nhập khóa học
        void InputFile()
        {
            try
            {
                FileStream f = new FileStream("D:\\HĐT\\quoclam_63132195\\HocVien.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(f);
                string line;//luu du lieu doc tung dong tu file ra chuong trinh
                while ((line = rd.ReadLine()) != null)//con dong du lieu trong file
                {
                    string[] item = line.Split(';');//6 phan tu trong item
                    int ms = int.Parse(item[0]);
                    string hoten = item[1];
                    string ns =  item[2];
                    string dt = item[3];
                    decimal thp = decimal.Parse(item[4]);
                    HocVien m = new HocVien(ms, hoten, ns, dt,thp);
                    hocvien.Add(m);
                }
                
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
        public void Set()
        {
            Console.Write("Nhập tên khóa học:");
            TenKH = Console.ReadLine();
            Console.Write("Nhập số lượng học viên:");
            SLHocVien = int.Parse(Console.ReadLine());
            //nhap danh sach cac mon hoc
            for(int i=0; i< SLHocVien;i++)
            {
                hocvien = new List<HocVien>();
                //nhap danh sach mon hoc: doc du lieu tu file
                InputFile();
            }
        }

        public void FindHocVien(int maso)
        {
            HocVien hv = hocvien.Find(s => s.ms == maso);

            if (hv != null)
            {
                Console.WriteLine("\nHọc viên có mã số {0} là {1}", hv.ms, hv.hoten);
            }
            else
            {
                Console.WriteLine("Không tìm thấy học viên có mã số {0}", maso);
            }
        }
        // thêm 
        public void AddHocVien()
        {
            Console.Write("Nhập thông tin học viên mới:\n");
            HocVien h = new HocVien();
            h.Set();
            hocvien.Add(h);
        }
        // xóa
        public void RemoveHocVien()
        {
            hocvien.RemoveAll(student => student.TienHP == 0);
            SLHocVien = hocvien.Count;
        }
        // sắp xếp
        public void Sort()
        {
            hocvien.Sort();
        }
        // Phương thức xuất danh sách học viên khóa học được sắp xếp theo thứ tự giảm dần của học phí (sử dụng IComparable, IComparer)
        public void Print()
        {
            Console.WriteLine("Danh sách học viên của khóa học {0}:", TenKH);
            foreach (HocVien hv in hocvien)
            {
                hv.Print_F();
            }
        }
    }
}
