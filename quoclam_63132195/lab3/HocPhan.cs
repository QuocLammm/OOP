using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class HocPhan
    {
        public string MaHocPhan { get; set; }
        public string TenHocPhan { get; set; }
        public int SoTinChi { get; set; }
        public int SoTinChiThucHanh { get; set; }
        public int HocPhiMotTinChi { get; set; } = 250;

        public HocPhan() { }

        public HocPhan(string ma, string ten, int stc, int stcth)
        {
            MaHocPhan = ma;
            TenHocPhan = ten;
            SoTinChi = stc;
            SoTinChiThucHanh = stcth;
        }

        public void NhapThongTin()
        {
            Console.Write("Nhập mã học phần: ");
            MaHocPhan = Console.ReadLine();
            Console.Write("Nhập tên học phần: ");
            TenHocPhan = Console.ReadLine();
            Console.Write("Nhập số tín chỉ: ");
            SoTinChi = int.Parse(Console.ReadLine());
            Console.Write("Nhập số tín chỉ thực hành: ");
            SoTinChiThucHanh = int.Parse(Console.ReadLine());
        }

        public double TinhTienHocPhi()
        {
            return SoTinChiThucHanh * HocPhiMotTinChi * 1.5 + (SoTinChi - SoTinChiThucHanh) * HocPhiMotTinChi;
        }

        public void Xuat()
        {
            Console.WriteLine("Mã học phần: " + MaHocPhan);
            Console.WriteLine("Tên học phần: " + TenHocPhan);
            Console.WriteLine("Số tín chỉ: " + SoTinChi);
            Console.WriteLine("Số tín chỉ thực hành: " + SoTinChiThucHanh);
            Console.WriteLine("Tiền học phí: " + TinhTienHocPhi());
        }

        public static HocPhan operator +(HocPhan hocPhan, double tienHocPhi)
        {
            hocPhan.HocPhiMotTinChi += (int)(tienHocPhi / hocPhan.SoTinChi);
            return hocPhan;
        }
    }

    class HoaDonHocPhi
    {
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public List<HocPhan> DanhSachHocPhan { get; set; }

        public HoaDonHocPhi()
        {
            DanhSachHocPhan = new List<HocPhan>();
        }

        public HoaDonHocPhi(string maSV, string hoTen)
        {
            MaSinhVien = maSV;
            HoTen = hoTen;
            DanhSachHocPhan = new List<HocPhan>();
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập thông tin hóa đơn học phí:");
            Console.Write("Mã số sinh viên: ");
            MaSinhVien = Console.ReadLine();
            Console.Write("Họ và tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập số lượng học phần (2-9): ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                HocPhan hp = new HocPhan();
                hp.NhapThongTin();
                DanhSachHocPhan.Add(hp);
            }

        }
        // Phương thức tính tổng số tín chỉ thực hành trong kỳ của sinh viên
        public int TinhTongTCTH()
        {
            int tongTCTH = 0;
            foreach (HocPhan hocPhan in DanhSachHocPhan)
            {
                tongTCTH += hocPhan.SoTinChiThucHanh;
            }
            return tongTCTH;
        }

        // Phương thức tính tổng tiền học phí của hóa đơn
        public double TinhTongTienHocPhi()
        {
            double tongTien = 0;
            foreach (HocPhan hocPhan in DanhSachHocPhan)
            {
                tongTien += hocPhan.TinhTienHocPhi();
            }
            return tongTien;
        }
        // xuất thông tin
        public void Xuat()
        {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Thông tin hóa đơn :");
        Console.WriteLine("Mã số sinh viên: " + MaSinhVien);
        Console.WriteLine("Họ và tên: " + HoTen);
        Console.WriteLine("Danh sách học phần:");
            foreach (HocPhan hocPhan in DanhSachHocPhan)
            {
                hocPhan.Xuat();
            }
        Console.WriteLine("Tổng tiền học phí: {0}", TinhTongTienHocPhi());
        Console.WriteLine("Tổng số tín chỉ thực hành: {0}", TinhTongTCTH());

        }
    }
}

