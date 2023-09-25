using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void BT5_1()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List_Rec ds = new List_Rec();
            ds.Input();
            Console.WriteLine("Danh sách n hình chữ nhật:");
            ds.Print();
            ds.Sort();
            Console.WriteLine("Danh sách sau khi xắp xếp:");
            ds.Print();
            ds.Delete();
            Console.WriteLine("Danh sách sau khi xóa:");
            ds.Print();
            ds.Add();
            Console.WriteLine("Danh sách sau khi thêm:");
            ds.Print();
            Console.WriteLine($"Tổng chi phí:{ds.Sum_Cost()}");
            
        }
        static void BT5_2()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            SinhVien sv = new SinhVien();
            sv.Set();
            sv.Print();
            if (sv.HocBong())
                Console.WriteLine("SV đủ điều kiện xét học bổng");
            else
                Console.WriteLine("SV không đủ điều kiện xét học bổng");

        }

        static void BT5_3()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            KhoaHoc p = new KhoaHoc();
            p.Set();
            p.Print();
            p.Sort();
            Console.Write("\nDanh sách đã sắp xếp theo học phí:\n");
            p.Print();
            p.FindHocVien(1234);
            p.AddHocVien();
            Console.Write("\nDanh sách khi thêm học viên:\n");
            p.Print();
            p.RemoveHocVien();
            Console.Write("\nXóa học phí =0:\n");
            p.Print();
        }
        static void BT5_4()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            ListNews newsList = new ListNews();
            int n = 0;
            do
            {
                Console.WriteLine("----------MENU----------");
                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average rate");
                Console.WriteLine("4. Exit");
                Console.Write("Mời bạn chọn: ");
                try
                {
                     n = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid choice!");
                    continue;
                }

                switch (n)
                {
                    case 1:
                        newsList.Add();
                        break;
                    case 2:
                        newsList.Output();
                        break;
                    case 3:
                        newsList.Avg_Rate();
                        Console.Write("Xuất thông tin:\n");
                        newsList.Output();
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (n != 4);
        }
        static void Main(string[] args)
        {
            Console.Write("------------Bài 1:-----------");
            BT5_1();
            Console.Write("------------Bài 2:-----------");
            BT5_2();
            Console.Write("------------Bài 3:-----------");
            BT5_3();
            Console.Write("------------Bài 4:-----------");
            BT5_4();    
            Console.ReadKey();
        }
    }
}
