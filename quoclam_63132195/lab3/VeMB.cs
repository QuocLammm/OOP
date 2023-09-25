using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class VeMB
    {
        string mave, hoten, loaive;
        DateTime ngaymua, ngaykh;
        static int giasan = 500;

        public string Loaive { get => loaive; set => loaive = value; }

        //khoi tao
        public VeMB()
        {
            mave = "VJ123"; hoten = "N.V.A";
            ngaymua = DateTime.Today;
            ngaykh = new DateTime(2023, 5, 1);//1/5/2023
            loaive = "First";
        }
        public VeMB(string ma, string ht, DateTime mua, DateTime kh, string loai)
        {
            mave = ma; hoten = ht; loaive = loai;
            ngaymua = mua; ngaykh = kh;
        }
        //nhap thong tin ve
        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập mã vé:");
            mave = Console.ReadLine();
            Console.Write("Nhập họ và tên:");
            hoten = Console.ReadLine();
            Console.Write("Nhập ngày mua:");
            ngaymua = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập ngày khởi hành:");
            ngaykh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập loại vé( First ( first) | Business ( business ) | Premium ( premium ):");
            loaive = Console.ReadLine();
        }
        //tinh tien ve
        public float TinhGiaVe()
        {
            float gia;//gia theo loaive
            if (loaive == "First" || loaive == "first")
                gia = giasan * 3;
            else if (loaive == "Business" || loaive == "business")
                gia = giasan * 2;
            else if (loaive == "Premium" || loaive == "premium")
                gia = giasan * 1.5f;
            else
                gia = giasan;
            int d = (ngaykh - ngaymua).Days;//tinh so ngay
            return (0.5f / 100 * d * gia) * 1.1f;
        }
        //xuat thong tin ve
        public void Xuat()
        {
            Console.WriteLine($"{mave}\t{hoten}\t{ngaykh.ToShortDateString()}\t{loaive}\t{TinhGiaVe()}");
        }
        //toan tu +
        public static float operator +(float s, VeMB ve)
        {
            return s + ve.TinhGiaVe();
        }
        //toan tu <,>
        public static bool operator <(VeMB v1, VeMB v2)
        {
            return v1.TinhGiaVe() < v2.TinhGiaVe();
        }
        public static bool operator >(VeMB v1, VeMB v2)
        {
            return v1.TinhGiaVe() > v2.TinhGiaVe();
        }
    }
    //class danh sach n ve may bay
    class DS_VeMB
    {
        VeMB[] ds;
        byte n;
        //phuong thuc nhap
        public void Nhap()
        {
            do
            {
                Console.Write("Nhập số lượng vé:");
                n = byte.Parse(Console.ReadLine());
            } while (n < 2 || n > 20);
            //khoi tao ds
            ds = new VeMB[n];
            //nhap n ve may bay
            for (int i = 0; i < n; i++)
            {
                ds[i] = new VeMB();
                ds[i].Nhap();
            }
        }

        //sap xep 
        public void SapXep()
        {
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (ds[i] < ds[j])//(ds[i].TinhGiaVe() < ds[j].TinhGiaVe())
                    {
                        VeMB ve = new VeMB();
                        ve = ds[i];
                        ds[i] = ds[j];
                        ds[j] = ve;
                    }
        }
        //xuat n ve ra man hinh
        public void XuatDS()
        {
            foreach (VeMB ve in ds)
                ve.Xuat();
        }
        //tinh trung binh
        public void TinhTB()
        {
            //tinh tong tien n ve
            float s = 0;
            foreach (VeMB ve in ds)
                s = s + ve;//s + ve.TinhGiaVe();
            Console.WriteLine("Tiền vé TB: {0}", s / n);
        }
        //dem so luong ve loai Business
        public void DemLoaiVe()
        {
            byte c = 0;
            foreach (VeMB ve in ds)
                if (ve.Loaive == "Business" || ve.Loaive == "business")
                    c++;
            Console.WriteLine("Số vé loại Business: {0}", c);
        }
    }
}
