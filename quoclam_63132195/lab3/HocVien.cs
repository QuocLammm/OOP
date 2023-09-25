using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class HocVien
    {
        // Các thuộc tính của lớp HocVien
        public string MaHocVien { get; set; }
        public string HoTen { get; set; }
        public string LopHoc { get; set; }
        public int SoTietHoc { get; set; }
        public static int HocPhiMotTietHoc { get; set; } = 100;

        // Các phương thức của lớp HocVien
        // Khởi tạo không tham số
        public HocVien()
        {
            MaHocVien = "JT63";
            HoTen = "Quốc Lâm";
            LopHoc = "A";
            SoTietHoc = 50;
        }

        // Khởi tạo có tham số
        public HocVien(string maHocVien, string hoTen, string lopHoc, int soTietHoc)
        {
            MaHocVien = maHocVien;
            HoTen = hoTen;
            LopHoc = lopHoc;
            SoTietHoc = soTietHoc;
        }

        // Phương thức nhập thông tin cho học viên
        public void NhapThongTin()
        {
            Console.Write("Nhập mã học viên: ");
            MaHocVien = Console.ReadLine();
            Console.Write("Nhập họ tên học viên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập lớp học (A, B, C): ");
            LopHoc = Console.ReadLine();
            Console.Write("Nhập số tiết học: ");
            SoTietHoc = int.Parse(Console.ReadLine());
        }

        // Phương thức tính tiền học phí phải đóng
        public double TinhTienHocPhi()
        {
            double tienGiam = 0;
            if (SoTietHoc > 50)
            {
                tienGiam = SoTietHoc * HocPhiMotTietHoc * 0.1;
            }
            else if (SoTietHoc > 30)
            {
                tienGiam = SoTietHoc * HocPhiMotTietHoc * 0.07;
            }
            double tongTien = SoTietHoc * HocPhiMotTietHoc - tienGiam;
            return tongTien;
        }

        // Phương thức xuất thông tin học viên
        public void Xuat()
        {
            Console.WriteLine($"Tên học viên: {HoTen}");
            Console.WriteLine($"Lớp học: {LopHoc}");
            Console.WriteLine($"Số tiết học: {SoTietHoc}");
            Console.WriteLine($"Tiền học phí: {TinhTienHocPhi()}");
        }

        // Định nghĩa toán tử cộng để cộng tiền học phí của học viên với một số
        public static double operator +(HocVien hocVien, double soTien)
        {
            return hocVien.TinhTienHocPhi() + soTien;
        }
    }
    // class DS hojc vieen
    class DS_HocVien
    {
        HocVien[] ds;
        int n;
        // phuwong thuwcs nhaapk
        public void Nhap()
        {
            do {
                Console.WriteLine("Nhập số học viên n : ");
                n = int.Parse(Console.ReadLine());
            } while (n < 2 || n > 30);
            // khởi tạo danh sách
            ds = new HocVien[n];

            // Nhập thông tin cho n học viên
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin học viên thứ {i + 1}:");
                ds[i] = new HocVien();
                ds[i].NhapThongTin();
            }
        }
        // Tính và xuất tổng số tiền học phí của n học viên
        public void TinhTienHocPhi() {
            
            double tongTienHocPhi = 0;
            foreach (var hocVien in ds)
            {
                tongTienHocPhi += hocVien.TinhTienHocPhi();
            }
            Console.WriteLine($"Tổng tiền học phí của {n} học viên là : {tongTienHocPhi}");
            Console.ReadKey();
        }
        public void XuatKQ()
        {

            // Xuất thông tin danh sách học viên
            Console.WriteLine("Danh sách học viên:");
            foreach (HocVien hv in ds)
            {
                hv.Xuat();
            }
        }
    }
}
