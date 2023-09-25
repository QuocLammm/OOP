using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Phanso
    {
        int tuSo;
        int mauSo;
        public Phanso()
        {
            tuSo = 2;
            mauSo = 3;
        }
        public Phanso(int ts, int ms)
        {
            tuSo = ts;
            mauSo = ms;
        }
        public Phanso(Phanso ps)
        {
            tuSo = ps.tuSo;
            mauSo = ps.mauSo;
        }
        //\phương thức cộng trừ nhân chia
        public Phanso Sum(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuSo = this.tuSo * p.mauSo + p.tuSo * this.mauSo;
            kq.mauSo = this.mauSo * p.mauSo;
            return kq;
        }
        public Phanso Tru(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuSo = this.tuSo * p.mauSo - p.tuSo * this.mauSo;
            kq.mauSo = this.mauSo * p.mauSo;
            return kq;
        }
        public Phanso Nhan(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuSo = this.tuSo * p.tuSo;
            kq.mauSo = this.mauSo * p.mauSo;
            return kq;
        }
        public Phanso Chia(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuSo = this.tuSo * p.mauSo;
            kq.mauSo = this.mauSo * p.tuSo;
            return kq;
        }
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 || b == 0)
                return 1;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        private void RutGon()
        {
            int ucln = UCLN(tuSo, mauSo);
            tuSo = tuSo / ucln;
            mauSo = mauSo / ucln;
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("{0}/{1}", tuSo, mauSo);
        }

        public static Phanso operator +(Phanso ps1, Phanso ps2)
        {
            Phanso tong = new Phanso();
            tong.tuSo = ps1.tuSo * ps2.mauSo + ps2.tuSo * ps1.mauSo;
            tong.mauSo = ps1.mauSo * ps2.mauSo;
            tong.RutGon();
            return tong;
        }

        public static Phanso operator -(Phanso ps1, Phanso ps2)
        {
            Phanso hieu = new Phanso();
            hieu.tuSo = ps1.tuSo * ps2.mauSo - ps2.tuSo * ps1.mauSo;
            hieu.mauSo = ps1.mauSo * ps2.mauSo;
            hieu.RutGon();
            return hieu;
        }

        public static Phanso operator *(Phanso ps1, Phanso ps2)
        {
            Phanso tich = new Phanso();
            tich.tuSo = ps1.tuSo * ps2.tuSo;
            tich.mauSo = ps1.mauSo * ps2.mauSo;
            tich.RutGon();
            return tich;
        }

        public static Phanso operator /(Phanso ps1, Phanso ps2)
        {
            Phanso thuong = new Phanso();
            thuong.tuSo = ps1.tuSo * ps2.mauSo;
            thuong.mauSo = ps1.mauSo * ps2.tuSo;
            thuong.RutGon();
            return thuong;
        }
    }
}
