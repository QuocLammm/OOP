using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiGK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            ChuNhat p = new ChuNhat();
            p.Nhap();
            ChuNhat p1= new ChuNhat();
            p1.Nhap();
            Console.WriteLine("Diện tích xung quanh hình hộp 1: {0}", p.DTXQ());
            Console.WriteLine("Thể tích hình hộp 1: {0}\t", p.TT());
            p.Xuat();

            Console.WriteLine("Diện tích xung quanh hình hộp 2: {0}", p1.DTXQ());
            Console.WriteLine("Thể tích hộp 2: {0}\t", p1.TT());
            p1.Xuat();

            if (p > p1)
            {
                Console.WriteLine("Diện tích xung quanh hình hộp 1 lớn hơn diện tích xung quanh hình hộp 2");
            }
            else
            {
                Console.WriteLine("Diện tích xung quanh hình hộp 1 nhỏ hơn diện tích xung quanh hình hộp 2");
            }

            p1++;
            Console.WriteLine("Chiều cao sau khi đã tăng lên 1:");
            p1.Xuat();
            Console.ReadKey();
        }
    }
}
