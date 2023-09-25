using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {//Bai 1.1
        static void BT1_1()
        {
            string hoten;
            DateTime ngaysinh;
            bool gioitinh;

            // nhap vao gia tri cho 3 bien
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();// phuong thuc nay tra ve kieu chuoi
            Console.Write("Nhap ngay sinh: ");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            gioitinh = Convert.ToBoolean(Console.ReadLine());
            // in ra man hinh
            if (gioitinh)
                Console.WriteLine($"{hoten}\t{ngaysinh.ToShortDateString()}\tNam");
            else
                Console.WriteLine($"{hoten}\t{ngaysinh.ToShortDateString()}\tNu");
        }
        //------------------------------------*****--------------------------------------------//
        //Bai 1.2
        static void BT1_2()
        {
            short a, b, c;
            //nhap 3 so nguyen
            Console.Write("Nhap a: ");
            a = Convert.ToSByte(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToSByte(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToSByte(Console.ReadLine());
            //kiem tra tang/giam
            Console.WriteLine($"\n {a} {b} {c}");
            if (a < b && b < c)
                Console.WriteLine("increasing!");
            else if (a > b && b > c)
                Console.WriteLine("decreasing!");
            else
                Console.WriteLine("neither increasing nor decreasing order");

        }
        //------------------------------------*****--------------------------------------------//
        static void BT1_3()
        {
            int a, b;
            char c;
            float kq = 0;
            Console.Write("Nhap a: ");
            a = Int16.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Int16.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToChar(Console.ReadLine());
            //tinh toan
            switch (c)
            {
                case '+': kq = a + b; break;
                case '-': kq = a - b; break;
                case '*': kq = a * b; break;
                case '/': kq = a / b; break;
            }
            Console.WriteLine($"{a} {c} {b} = {kq}");
        }
        //------------------------------------*****--------------------------------------------//
        static void BT1_4()
        {
            int a;
            int i = 1;
            Console.Write("Moi nhap mat khau:");
            a = Int16.Parse(Console.ReadLine());
            do
            {
                i++;
                Console.Write("Mat khau khong hop le!");
                Console.Write("\nNhap lai mat khau:");
                a = Int16.Parse(Console.ReadLine());
                if (i >= 3)
                {
                    Console.WriteLine("Dang nhap khong thanh cong!");
                    return;
                }
            }
            while (a != 123);
            Console.Write("Dang nhap thanh cong!");

        }

        static void Hoandoi(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        // Kiểm tra số nguyên tố
        static bool KTNT(int x)
        {
            if (x < 2) return false;// không là nguyên tố
            for (int i = 2; i < x - 1; i++)
                if (x % i == 0)
                    return false;
            return true;
        }
        //------------------------------------*****--------------------------------------------//
        static void BT1_5()
        {
            int n;
            int[] a;//khai báo
            Console.Write("Nhap so phan tu cua mang:");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 3 || n > 20)
            {
                Console.Write("Nhap lai so phan tu");
            }
            a = new int[n];// Khởi tạo mảng a có n phần tử
            //nhập giá trị cho phần tử
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a{i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            // sắp xếp tăng dần
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (a[i] > a[j])
                        Hoandoi(ref a[i], ref a[j]);
            //In ra màn hình cách thường
            //for (int i = 0;i < n; i++)
            //Console.Write($"a{i} ");
            foreach (int x in a)
                Console.Write($"{x} ");
            // đếm số lượng số nguyên tố
            byte c = 0;
            foreach (int x in a)
                if (KTNT(x))
                    c++;
            Console.WriteLine($"\nCo {c} so nguyen to trong mang");
        }
        //------------------------------------*****--------------------------------------------//
        static void BT1_6()
        {
            int y;
            Console.Write("Nhap nam: ");
            y = int.Parse(Console.ReadLine());
            if (y % 4 == 0 && 100 != 0 || y % 400 == 0)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }
        //------------------------------------*****--------------------------------------------//
        static void BT1_7()
        {
            Random rd = new Random();
            int bot;
            string tmp1 = "", tmp2 = "";
            Console.WriteLine("\t**********************************");
            Console.WriteLine("\t*   Tro choi keo, bua, bao       *");
            Console.WriteLine("\t*      Chon 1 la keo             *");
            Console.WriteLine("\t*      Chon 2 la bua             *");
            Console.WriteLine("\t*      Chon 3 la bao             *");
            Console.WriteLine("\t**********************************");
            while (true)
            {
                bot = rd.Next(1, 4);
                Console.WriteLine("Moi ban chon:");
                int mt;
                while (true)
                {
                    mt = int.Parse(Console.ReadLine());
                    if (mt > 0 && mt < 4) break;
                    Console.WriteLine("Ban da nhap sai, Vui long nhap lai lua chon:");
                }
                switch (mt)
                {
                    case 1:
                        tmp1 = "keo";
                        break;
                    case 2:
                        tmp1 = "bua";
                        break;
                    case 3:
                        tmp1 = "bao";
                        break;
                    default:
                        break;
                }
                switch (bot)
                {
                    case 1:
                        tmp2 = "keo";
                        break;
                    case 2:
                        tmp2 = "bua";
                        break;
                    case 3:
                        tmp2 = "bao";
                        break;
                    default:
                        break;
                }
                int res = 1;
                switch (mt)
                {
                    case 1:
                        if (bot == 2) res = 2;
                        else if (bot == 3) res = 1;
                        else res = 3;
                        break;
                    case 2:
                        if (bot == 3) res = 2;
                        else if (bot == 1) res = 1;
                        else res = 3;
                        break;
                    case 3:
                        if (bot == 1) res = 2;
                        else if (bot == 2) res = 1;
                        else res = 3;
                        break;

                }
                string tmp3 = "";
                switch (res)
                {
                    case 1:
                        tmp3 = "Thang";
                        break;
                    case 2:
                        tmp3 = "Thua";
                        break;
                    case 3:
                        tmp3 = "Hoa";
                        break;
                }
                Console.WriteLine("\nBan da chon " + tmp1);
                Console.WriteLine("May da chon " + tmp2);
                Console.WriteLine("-------Ket qua------");
                Console.WriteLine("---------" + tmp3 + "------");

                // khoang cach 

                Console.WriteLine("Ban co muon choi tiep khong?  1- Co | 2 - Khong>:");
                int ch = 0;
                ch = int.Parse(Console.ReadLine());
                if (ch == 2)
                {
                    Console.WriteLine("Hen gap lai!");
                    break;
                }

                //các lệnh thực hiện theo yêu cầu đề bài
                ConsoleKeyInfo phim = Console.ReadKey(true);
                if (phim.Key == ConsoleKey.Escape) //nếu phím bấm là Esc thì dừng
                    break;
            }
        }

        //----------------------------------------------************---------------------------//
        static void BT1_8()
        {
            Console.WriteLine("Cau a: a=15, b=10\n");
            Console.WriteLine("Cau b: a=1, b=0\n");
            Console.WriteLine("Cau c: Chua bien doi kieu du lieu \n");
            Console.WriteLine("Cau d: Chua gan gia tri true/false cho chk \n");
            Console.WriteLine("Cau e: a=1 \n");


        }
        //------------------------------------*****--------------------------------------------//
        static void Main(string[] args)
        {
            BT1_1();
            Console.WriteLine("\n");
            BT1_2();
            Console.WriteLine("\n");
            BT1_3();
            Console.WriteLine("\n");
            BT1_4();
            Console.WriteLine("\n");
            BT1_5();
            Console.WriteLine("\n");
            BT1_6();
            Console.WriteLine("\n");
            BT1_7();
            Console.WriteLine("\n");
            BT1_8();
            Console.ReadKey();
        }
    }
}