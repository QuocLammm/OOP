using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Adult
    {
        string name;
        float w, h;
        // khởi tạo không tham số
        public Adult()
        {
            name = "H.I.V";
            w = 57; h = 1.8f;

        }
        public Adult(string name, float w, float h)
        {
            this.name = name;
            this.w = w;
            this.h = h;
        }
        //khởi tạo sao chép
        public Adult(Adult a)
        {
            name = a.name;
            w = a.w;
            h = a.h;
        }
        public void Print()
        {
            Console.WriteLine($"{name}\t can nang: {w}kg\t cao : {h}m");
            float bmi = w / (h * h);
            if (bmi < 18.5f)
            {
                Console.WriteLine(" Nhe can !");
            }
            else if (bmi <= 25)
                Console.WriteLine(" Binh thuong ( suc khoa tot) !");
            else if (bmi < 30)
                Console.WriteLine(" Thua can !");
            else
                Console.WriteLine("Beo phi !");

        }
        // lời khuyên của bác sĩ
        public void Inc_Dec()
        {
            float bmi = w / (h * h);
            float w1 = 18.5f * h * h;
            float w2 = 25f * h * h;
            if (bmi < 18.5f)
                Console.WriteLine($" tang toi thieu {w1 - w}kg, tang toi da {w2 - w}kg");
            else if (bmi >= 25)
                Console.WriteLine($" giam toi thieu {w - w2}kg, giam toi da {w - w1}kg");

        }
    }
}
