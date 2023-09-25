using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using textthi;


namespace textthi
{

    internal class Program
    {
        static void BT1()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<XeVinfast> danhSachXe = new List<XeVinfast>();

            // Nhập danh sách n xe VINFAST
            Console.Write("Nhập số lượng xe VINFAST: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                XeVinfast xe = new XeVinfast();
                xe.Nhap();
                danhSachXe.Add(xe);
            }

            // Sắp xếp danh sách xe VINFAST theo chiều giảm dần của giá lăn bánh
            Console.Write("Danh sách đã sắp xếp theo chiều giảm dần: ");
            danhSachXe.Sort((s, y) => y.TinhGiaLanBanh().CompareTo(s.TinhGiaLanBanh()));

            // Xuất danh sách xe VINFAST và các thông số kèm theo
            Console.WriteLine("Danh sách xe VINFAST:");
            foreach (var xe in danhSachXe)
            {
                xe.Xuat();
                Console.WriteLine("Giá lăn bánh: " + xe.TinhGiaLanBanh());
                Console.WriteLine("--------------------------------");
            }

            // Thêm 1 xe VINFAST vào vị trí thứ p trong danh sách
            Console.Write("Nhập vị trí (p) muốn thêm xe VINFAST vào danh sách: ");
            int p = int.Parse(Console.ReadLine());

            if (p >= 0 && p <= danhSachXe.Count)
            {
                XeVinfast newCar = new XeVinfast();
                newCar.Nhap();
                danhSachXe.Insert(p, newCar);
                Console.WriteLine("Đã thêm xe VINFAST vào vị trí " + p);
            }
            else
            {
                Console.WriteLine("Vị trí không hợp lệ!");
            }

            // Xóa tất cả các xe VINFAST có dòng xe là x
            Console.Write("Nhập dòng xe (x) muốn xóa: ");
            string x = Console.ReadLine();

            danhSachXe.RemoveAll(xe => xe.DongXe.ToLower() == x.ToLower());

            Console.WriteLine("Đã xóa tất cả các xe VINFAST có dòng xe " + x);

            // Xuất danh sách xe VINFAST và các thông số kèm theo sau khi thay đổi
            Console.WriteLine("Danh sách xe VINFAST sau khi thay đổi:");
            foreach (var xe in danhSachXe)
            {
                xe.Xuat();
                Console.WriteLine("Giá lăn bánh: " + xe.TinhGiaLanBanh());
                Console.WriteLine("--------------------------------");
            }
        }


        static void Main(string[] args)
        {
            BT1();
        }
            
    }
}



