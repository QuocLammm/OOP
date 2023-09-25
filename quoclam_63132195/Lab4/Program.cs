using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab4.MayTinh;

namespace Lab4
{
    internal class Program
    {

        static void BT4_1()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            PT pT = new PT();
            pT.Nhap();
            pT.Giai();
            pT.Print();

            PTB2 pT2 = new PTB2();
            pT2.Nhap();
            pT2.Giai();
            pT2.Print();
            Console.ReadKey();
        }

        static void BT4_2()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List_SmartPhone ls = new List_SmartPhone();
            ls.Input();
            Console.WriteLine("Danh sách n smartphone:");
            ls.Print();
            ls.Add();
            Console.WriteLine("Danh sách smartphone sau khi thêm:");
            ls.Print();
            ls.Delete();
            Console.WriteLine("Danh sách smartphone sau khi xóa:");
            ls.Print();
            ls.Sort();
            Console.WriteLine("Danh sách smartphone sau sắp xếp:");
            ls.Print();

        }

        static void BT4_3()
        {
            Console.InputEncoding= Encoding.UTF8;
            Console.OutputEncoding= Encoding.UTF8;
            Console.Write("Nhập số lượng hình: ");
            int n = int.Parse(Console.ReadLine());

            Shape[] shapes = new Shape[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập loại hình dạng (1 - Hinh tam giac, 2 - Hinh chu nhat):");
                int type = int.Parse(Console.ReadLine());

                Console.Write("Nhập tên hình dạng: ");
                string name = Console.ReadLine();

                if (type == 1)
                {
                    Console.Write("Nhập độ dài cạnh a: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Nhập chiều dài cạnh b: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.Write("Nhập chiều dài cạnh c: ");
                    double c = double.Parse(Console.ReadLine());

                    shapes[i] = new Triangle(name, a, b, c);
                }
                else if (type == 2)
                {
                    Console.Write("Nhập chiều rộng: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.Write("Nhập chiều cao: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes[i] = new Rectangle(name, width, height);
                }
            }

            Console.WriteLine("\nXuất thông tin hình dạng:");
            foreach (Shape shape in shapes)
            {
                shape.Print();
                Console.WriteLine();
            }
            double sum = 0;
            int count = 0;

            foreach (Shape shape in shapes)
            {
                if (shape.GetType() == typeof(Rectangle))
                {
                    sum += shape.Area();
                    count++;
                }
            }

            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine("Diện tích trung bình của hình chữ nhật: {0}", average);
            }
            else
            {
                Console.WriteLine("Không tìm thấy hình chữ nhật nào");
            }
        }

        static void Bt4_4()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập số lượng máy tính (2 <= n <= 30): ");
            int n = int.Parse(Console.ReadLine());

            Computer[] computers = new Computer[n];
            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Chọn loại máy tính (1: Laptop, 2: Macbook): ");
                int type = int.Parse(Console.ReadLine());
                
                if (type == 1)
                {
                    computers[i] = new Laptop();
                    computers[i].NhapThongTin();
                    
                    computers[i].XuatThongTin();

                }
                else if(type == 2) 
                {
                    computers[i] = new MacBook();
                    computers[i].NhapThongTin();
                    
                    computers[i].XuatThongTin();
                }
            }

            Console.WriteLine("\nDanh sách máy tính:");
            for (int i = 0; i < n; i++)
            {
                computers[i].XuatThongTin();
            }
            int laptopCount = 0;
            int macbookCount = 0;

            foreach (Computer computer in computers)
            {
                if (computer is Laptop)
                {
                    laptopCount++;
                }
                else
                {
                    macbookCount++;
                }
            }

            Console.WriteLine($"\tSố lương Laptop:{laptopCount}" );
            Console.WriteLine($"\tSố lượng Macbook:{macbookCount} ");
        }

        static void BT4_5()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("\nCâu a đáp án là: 3       5       7");
            Console.Write("\nCâu b đáp án là: 2       4");
            Console.Write("\nCâu c đáp án là: 1       4");
            Console.Write("\nCâu d đáp án là: 1       5       7");
            Console.Write("\nCâu e đáp án là: 1       2       7");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**************Bài 1***********");
            BT4_1();
            Console.WriteLine("**************Bài 2***********");
            BT4_2();
            Console.WriteLine("**************Bài 3***********");
            BT4_3();
            Console.WriteLine("**************Bài 4***********");
            Bt4_4();
            Console.WriteLine("**************Bài 5***********");
            BT4_5();
            Console.ReadKey();
        }
    }
}
