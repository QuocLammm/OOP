using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textthi
{
    class Xe
    {
        public string DongXe { get; set; }
        public int SoChoNgoi { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public static int GiaSan { get; } = 400;

        public void Nhap()
        {
            Console.WriteLine("Nhập thông tin xe :");
            Console.Write("Dòng xe: ");
            DongXe = Console.ReadLine();
            Console.Write("Số chỗ ngồi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("Ngày sản xuất (dd/mm/yyyy): ");
            NgaySanXuat = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        }

        public void Xuat()
        {
            Console.WriteLine("Thông tin xe:");
            Console.WriteLine("Dòng xe: " + DongXe);
            Console.WriteLine("Số chỗ ngồi: " + SoChoNgoi);
            Console.WriteLine("Ngày sản xuất: " + NgaySanXuat.ToString("dd/MM/yyyy"));
        }

        public double TinhGiaBan()
        {
            int namHienTai = DateTime.Now.Year;
            int namSanXuat = NgaySanXuat.Year;
            int soNam = namHienTai - namSanXuat;

            if (soNam > 2)
                return GiaSan * 1.15;
            else if (soNam > 1)
                return GiaSan * 1.3;
            else
                return GiaSan * 1.5;
        }
    }

    // Giao diện Phí
    interface IPhi
    {
        double PhiTruocBac { get; set; }

        double TinhTienPhiTruocBac(double giaBanXe);
    }

    // Lớp Xe VINFAST
    class XeVinfast : Xe, IPhi
    {
        public string NoiDangKy { get; set; }
        public double PhiTruocBac { get; set; }

        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nơi đăng ký: ");
            NoiDangKy = Console.ReadLine();
            Console.Write("Phí trước bạ (%): ");
            PhiTruocBac = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Nơi đăng ký: " + NoiDangKy);
            Console.WriteLine("Phí trước bạ: " + PhiTruocBac);
        }

        public double TinhTienPhiTruocBac(double giaBanXe)
        {
            return PhiTruocBac * giaBanXe;
        }

        public double TinhPhiDangKy()
        {
            double phiDangKy;
            if (NoiDangKy.ToLower() == "ha noi")
                phiDangKy = 0.12;
            else
                phiDangKy = 0.1;
            return phiDangKy * TinhGiaBan();
        }

        public double TinhGiaLanBanh()
        {
            double giaBanXe = TinhGiaBan();
            double tienPhiTruocBac = TinhTienPhiTruocBac(giaBanXe);
            double phiDangKy = TinhPhiDangKy();
            return giaBanXe + tienPhiTruocBac + phiDangKy;
        }
    }
}