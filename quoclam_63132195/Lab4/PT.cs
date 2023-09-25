using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab4
{
    internal class PT
    {
        protected int b;
        protected int c;
        // Không tham số
        public PT()
        {
            b = 1;
            c = 2;
        }
        //có tham số
        public PT(int b, int c) 
        {
            this.b = b;
            this.c = c;
        }

        public void Nhap()
        {
            Console.Write("Nhập b: ");
            b=int.Parse(Console.ReadLine());
            Console.Write("Nhập c: ");
            c =int.Parse(Console.ReadLine());
        }

        
        public void Print()
        {
            Console.WriteLine("Phương trình bậc nhất có dạng: {0}x + {1} = 0", b, c);
        }

        public void Giai()
        {
            int x;
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phương trình vô số nghiệm");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
            }
            else
            {
                x = -c / b;
                Console.WriteLine($"Phương trình có nghiệm là x={x}");
            }
        }
    }
    // Lớp PTB2 kế thừa PT
    class PTB2 : PT
    {
        int a;
        public PTB2()
        {
            a = 1;
        }
        public PTB2(int a, int b,int c): base(b, c)
        {
            this.a = a;
        }

        public new void Nhap()
        {
            Console.WriteLine("Nhập hệ số a: ");
            a = int.Parse(Console.ReadLine()) ;
            base.Nhap();
        }

        public new void Print()
        {
            Console.WriteLine($"Phương trình bậc 2: {a}x^2 + {b}x + {c} = 0");
        }

        public new void Giai()
        {
            if (a == 0)
            {
                base.Giai();
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm !");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phương trình có nghiệm kép  x = {0}", x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phương trình có hai nghiệm phân biệt là x1 = {0} va x2 = {1}", x1, x2);
                }
            }
        }
    }
}
