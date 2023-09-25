using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    internal class Program
    {
        class PTB1
        {
            protected int a, b;
            public PTB1(int a1 = 2, int b1 = 4)
            {
                a = a1; b = b1;
            }
            public void Xuat()
            {
                Console.Write($"{a}\t{b}");
            }
        }
        class PTB2 : PTB1
        {
            int c;
            public PTB2(int a = 3, int b = 5, int c = 7) : base(a, b)
            {
                this.c = c;
            }
            public new void Xuat()
            {
                base.Xuat();
                Console.Write($"\t{c}");
            }
        }
        static void Main(string[] args)
        {
            PTB2 p = new PTB2();
            p.Xuat();


            Console.ReadKey();

        }
    }
}
