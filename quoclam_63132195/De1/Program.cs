using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding=Encoding.UTF8;
            Console.OutputEncoding=Encoding.UTF8;
            Console.Write("Nhập số lượng mặt hàng nhập khẩu (0 < n <= 30): ");
            int n = int.Parse(Console.ReadLine());

            List<MatHangNhapKhau> ds = new List<MatHangNhapKhau>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin mặt hàng nhập khẩu thứ " + (i + 1));
                MatHangNhapKhau matHangNhapKhau = new MatHangNhapKhau();
                matHangNhapKhau.Nhap();
                ds.Add(matHangNhapKhau);
            }

            Console.WriteLine("Thông tin " + n + " mặt hàng nhập khẩu:");

            foreach (MatHangNhapKhau matHangNhapKhau in ds)
            {
                matHangNhapKhau.XuatThongTinNhapKhau();
                Console.WriteLine();
            }

            double tongTienBanNam2022 = 0;
            double tongTienThue = 0;

            foreach (MatHangNhapKhau matHangNhapKhau in ds)
            {
                if (matHangNhapKhau.NgayNhap.Year == 2022)
                {
                    tongTienBanNam2022 += matHangNhapKhau.TinhGiaBanNhapKhau();
                }

                tongTienThue += matHangNhapKhau.TinhTienThue();
            }

            Console.WriteLine("Tổng số tiền bán các mặt hàng nhập khẩu trong năm 2022: " + tongTienBanNam2022);
            Console.WriteLine("Tiền thuế trung bình của các mặt hàng nhập khẩu: " + (tongTienThue / ds.Count));
            Console.ReadKey();
        }
    }
}
