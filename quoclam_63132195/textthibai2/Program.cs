using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textthibai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<Xe> danhSachXe = new List<Xe>();
            // Nhập danh sách n xe cho phép chọn loại xe KIA hoặc VINFAST khi nhập
            Console.Write("Nhập số lượng xe: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Xe thứ " + (i + 1));
                Console.WriteLine("1. Xe KIA");
                Console.WriteLine("2. Xe VINFAST");
                Console.Write("Chọn loại xe (1-2): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        XeKia kia = new XeKia();
                        kia.Nhap();
                        danhSachXe.Add(kia);
                        break;
                    case 2:
                        XeVinfast vinfast = new XeVinfast();
                        vinfast.Nhap();
                        danhSachXe.Add(vinfast);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }

            // Xuất thông tin của n xe sắp xếp theo chiều tăng dần của năm sản xuất
            danhSachXe = danhSachXe.OrderBy(xe => xe.NamSanXuat).ToList();
            Console.WriteLine("Danh sách xe:");
            foreach (var xe in danhSachXe)
            {
                xe.Xuat();
                Console.WriteLine("--------------------------------");
            }

            // Tính và in ra giá lăn bánh trung bình của các xe VINFAST có số chỗ ngồi là x
            Console.Write("Nhập số chỗ ngồi (x): ");
            int x = int.Parse(Console.ReadLine());

            var xeVinfastCoSoChoNgoiX = danhSachXe.OfType<XeVinfast>().Where(xe => xe.SoChoNgoi == x);
            if (xeVinfastCoSoChoNgoiX.Any())
            {
                double giaLanBanhTrungBinh = xeVinfastCoSoChoNgoiX.Average(xe => xe.TinhGiaLanBanh());
                Console.WriteLine("Giá lăn bánh trung bình của các xe VINFAST có số chỗ ngồi " + x + " là: " + giaLanBanhTrungBinh);
            }
            else
            {
                Console.WriteLine("Không có xe VINFAST nào có số chỗ ngồi " + x);
            }

            // Đếm và in ra số lượng xe KIA nhập khẩu trong năm nay
            int soLuongXeKiaNhapKhau = danhSachXe.OfType<XeKia>().Count(xe => xe.NhapKhau && xe.NamSanXuat == DateTime.Now.Year);
            Console.WriteLine("Số lượng xe KIA nhập khẩu trong năm nay: " + soLuongXeKiaNhapKhau);
        }
    }
}
