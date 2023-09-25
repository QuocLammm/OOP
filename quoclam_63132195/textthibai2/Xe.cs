using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textthibai2
{
    internal class Xe
    {
            public string DongXe { get; set; }
            public int SoChoNgoi { get; set; }
            public int NamSanXuat { get; set; }
            public static int GiaSan { get; } = 300;

            public void Nhap()
            {
                Console.WriteLine("Nhập thông tin xe:");
                Console.Write("Dòng xe: ");
                DongXe = Console.ReadLine();
                Console.Write("Số chỗ ngồi: ");
                SoChoNgoi = int.Parse(Console.ReadLine());
                Console.Write("Năm sản xuất: ");
                NamSanXuat = int.Parse(Console.ReadLine());
            }

            public void Xuat()
            {
                Console.WriteLine("Thông tin xe:");
                Console.WriteLine("Dòng xe: " + DongXe);
                Console.WriteLine("Số chỗ ngồi: " + SoChoNgoi);
                Console.WriteLine("Năm sản xuất: " + NamSanXuat);
                Console.WriteLine("Giá bán: " + TinhGiaBan());
                Console.WriteLine("Giá lăn bánh: " + TinhGiaLanBanh());
            }

            public double TinhGiaBan()
            {
                if (NamSanXuat == DateTime.Now.Year)
                    return GiaSan * 1.3;
                else
                    return GiaSan;
            }

            public double TinhGiaLanBanh()
            {
                return TinhGiaBan();
            }
        }

        // Lớp Xe KIA
        class XeKia : Xe
        {
            public bool NhapKhau { get; set; }

            public void Nhap()
            {
                base.Nhap();
                Console.Write("Nhập khẩu (true/false): ");
                NhapKhau = bool.Parse(Console.ReadLine());
            }

            public double TinhThueNhapKhau()
            {
                if (!NhapKhau)
                    return 0;

                if (SoChoNgoi < 5)
                    return 0.1 * TinhGiaBan();
                else
                    return 0.2 * TinhGiaBan();
            }

            public double TinhGiaLanBanh()
            {
                return TinhGiaBan() + TinhThueNhapKhau();
            }
        }

        // Lớp Xe VINFAST
        class XeVinfast : Xe
        {
            public string NoiDangKy { get; set; }

            public void Nhap()
            {
                base.Nhap();
                Console.Write("Nơi đăng ký: ");
                NoiDangKy = Console.ReadLine();
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
                return TinhGiaBan() + TinhPhiDangKy();
            }
        }
    }
