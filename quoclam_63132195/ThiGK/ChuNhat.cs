using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiGK
{
    internal class ChuNhat
    {
        //Khoiwr tao ko tham số
        int d;
        int r;
        int h;
        public ChuNhat()
        {
            d = 1; r = 2; h = 3;
        }
        // Khởi tạo có tham số
        public ChuNhat(int d, int r, int h)
        {
            this.d = d;
            this.r = r;
            this.h = h;
        }
        //Khởi tạo sao chép
        public ChuNhat(ChuNhat cn)
        {
            this.d = cn.d;
            this.r = cn.r;
            this.h = cn.h;
        }
        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            if (d > 0 && r > 0 && h > 0)
            {
                Console.Write("Nhập chiều dài:");
                d = int.Parse(Console.ReadLine());
                Console.Write("Nhập chiều rộng:");
                r = int.Parse(Console.ReadLine());
                Console.Write("Nhập chiều cao:");
                h = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Bạn đã nhập sai mời nhập lại !");
            }
        }
        public int DTXQ()
        {
            return  (2 * (d + r) * h); 
        }

        public int TT() 
        {
            return (d * r * h);
        }

        public void Xuat() 
        {
            Console.WriteLine($"\tChiều dài: {d}\t Chiều rộng: {r}\t Chiều Cao: {h}\t Thể tích: {TT()}\t");
        }

        public static ChuNhat operator ++(ChuNhat chuNhat)
        {
            chuNhat.h ++;
            return chuNhat;
        }

        public static bool operator >(ChuNhat s, ChuNhat x)
        {
            return s.DTXQ() > x.DTXQ();
        }

        public static bool operator <(ChuNhat s, ChuNhat x)
        {
            return  x.DTXQ() < s.DTXQ();
        }
    }
}
