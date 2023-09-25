using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1
{
    interface IThue
    {
        double TinhTienThue();
    }
    internal class MatHang
    {
        string maso { get; set; }
        string tenhang { get; set; }

        private double dongia { get; set; }
        // Không tham số
        public MatHang()
        {
            maso = "S123";
            tenhang = "B";
            dongia = 100;
        }
        // có tham số
        public MatHang(string maso, string tenhang, double dongia)
        {
            this.maso= maso;
            this.tenhang= tenhang;
            this.dongia= dongia;
        }
        // Phương thức Nhập
        public virtual void Nhap()
        {
            Console.Write("Nhập mã số:");
            maso = Console.ReadLine();
            Console.Write("Nhập tên hàng:");
            tenhang = Console.ReadLine();
            Console.Write("Nhập đơn giá:");
            dongia= double.Parse(Console.ReadLine());
        }
        // Phương thức Xuất
        public void Xuat()
        {
            Console.WriteLine("Thông tin mặt hàng:");
            Console.WriteLine($"Mã số là: {maso}");
            Console.WriteLine($"Tên hàng là: {tenhang}");
            Console.WriteLine($"Đơn giá : {dongia}");
        }
        //phương thức tính giá bán
        public double TinhGiaBan()
        {
            return dongia * 1.2;
        }
    }

    // Lớp Mặt hàng nhập khẩu kế thừa từ Mặt hàng và thực thi giao diện Thuế
    class MatHangNhapKhau : MatHang, IThue
    {
        private double dongia;
        public DateTime NgayNhap { get; set; }
        public double ThueNhapKhau { get; set; }

        public MatHangNhapKhau() : base()
        {
            NgayNhap = DateTime.Now;
            ThueNhapKhau = 0;
        }

        public MatHangNhapKhau(string maSo, string tenHang, double donGiaNhap, DateTime ngayNhap, double thueNhapKhau)
            : base(maSo, tenHang, donGiaNhap)
        {
            NgayNhap = ngayNhap;
            ThueNhapKhau = thueNhapKhau;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Ngày nhập (dd/MM/yyyy): ");
            NgayNhap = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Thuế nhập khẩu (%): ");
            ThueNhapKhau = double.Parse(Console.ReadLine());
        }

        public double TinhTienThue()
        {
            return ThueNhapKhau * dongia;
        }

        public double TinhGiaBanNhapKhau()
        {
            return TinhGiaBan() + TinhTienThue();
        }
        public void XuatThongTinNhapKhau()
        {
            base.Xuat();
            Console.WriteLine("Ngày nhập: " + NgayNhap.ToString("dd/MM/yyyy"));
            Console.WriteLine($"Thuế nhập khẩu: {ThueNhapKhau} %" );
            Console.WriteLine("Giá bán mặt hàng nhập khẩu: " + TinhGiaBanNhapKhau());
        }
    }

}
