using DocumentFormat.OpenXml.Bibliography;
using Lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Phone
    {
        protected int maso;
        protected string nhanhieu;
        protected double gianhap;
        protected int namsx;
        public float Gia { get => (float)gianhap ; set => gianhap = value; }
        public int Namsx { get => namsx; set => namsx = value; }

        public Phone()
        {
            maso = 0;
            nhanhieu = "samsung";
            gianhap = 2000;
            namsx = 2022;
        }

        public Phone(int maso, string nhanhieu, double gianhap, int namsx)
        {
            this.maso = maso;
            this.nhanhieu = nhanhieu;
            this.gianhap = gianhap;
            this.namsx = namsx;
        }

        public void Nhap()
        {
            Console.Write("Nhập mã số: ");
            maso = int.Parse(Console.ReadLine());

            Console.Write("Nhập nhãn hiệu (Iphone| Samsung | Nokia): ");
            nhanhieu = Console.ReadLine();

            Console.Write("Nhập giá nhập hàng: ");
            gianhap = double.Parse(Console.ReadLine());

            Console.Write("Nhập năm sản xuất: ");
            namsx = int.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Mã số: {maso}\tNhãn hiệu: {nhanhieu}\tGiá nhập hàng: {gianhap}\tNăm sản xuất: {namsx}");
        }

        public double Tinhthue()
        {
            if (nhanhieu == "Iphone" || nhanhieu == "iphone")
                return gianhap * 0.1;
            else
                return gianhap * 0.05;
        }
    }
    class SmartPhone : Phone
    {
        public int DLBN;
        public SmartPhone():base()
        {
            DLBN = 256;
        }

        public SmartPhone(int maso, string nhanhieu, double gianhap, int namsx, int DLBN) : base(maso, nhanhieu, gianhap, namsx)
        {
            this.DLBN = DLBN;
        }

        public new void Nhap()
        {
            base.Nhap();

            Console.Write("Nhập dung lượng (GB): ");
            DLBN = int.Parse(Console.ReadLine());
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Dung lượng bộ nhớ là : {DLBN}\t");
        }

        public float Price()
        {
            float Sale = 0;
            if (DLBN >= 128)
                Sale = (float)(gianhap + (20 / 100 * gianhap) + Tinhthue());
            else if (DLBN > 16)
                Sale = (float)(gianhap + 10 / 100 * gianhap + Tinhthue());
            else
                Sale = (float)(gianhap + 5 / 100 * gianhap + Tinhthue());
            return Sale;
        }
    }
    //danh sach n smartphone
    class List_SmartPhone
    {
        SmartPhone[] ls;
        int n;
        //su dung khoi tao khong tham so mac dinh
        //nhap
        public void Input()
        {
            Console.Write("Nhập số lượng Smartphone(2<n<30)");
            while (!(int.TryParse(Console.ReadLine(), out n)) || n < 2 || n > 30)
            {
                Console.Write("Nhập lại n:");
            }
            //khoi tao mang ls
            ls = new SmartPhone[n + 1];
            //nhap vao cac phan tu
            for (int i = 0; i < n; i++)
            {
                ls[i] = new SmartPhone();
                ls[i].Nhap();
            }
        }
        //them 1 smartphone
        public void Add()
        {
            Console.WriteLine("Nhập vào đối tượng cần thêm:");
            SmartPhone s = new SmartPhone();
            s.Nhap();
            Console.Write("Nhập vào vị trí cần chèn:");
            int p = int.Parse(Console.ReadLine());
            if (p >= 0 && p < n)
            {
                ls[n] = new SmartPhone();
                for (int i = n; i > p; i--)
                    ls[i] = ls[i - 1];
                n++;
            }
            else
                Console.WriteLine("Vị trí không hợp lệ!");
        }
        //xoa 1 phan tu
        public void Delete()
        {
            for (int i = 0; i < n; i++)
                if (ls[i].Namsx == DateTime.Now.Year)
                {
                    for (int j = i; j < n - 1; j++)
                        ls[j] = ls[j + 1];
                    n--;
                    break;
                }
        }
        //sap xep
        public void Sort()
        {
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (ls[i].Gia < ls[j].Gia)
                    {
                        SmartPhone s = new SmartPhone();
                        s = ls[i];
                        ls[i] = ls[j];
                        ls[j] = s;
                    }
        }
        //xuat danh sach
        public void Print()
        {
            for (int i = 0; i < n; i++)
                ls[i].Print();
        }
    }
}
