using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10._04._23
{
    internal class Text:IComparable<Text>
    {
        private string ms;
        private string hoten;
        private float dtb;

        public Text(string ms, string hoten, float dtb)
        {
            this.ms = ms;
            this.hoten = hoten;
            this.dtb = dtb;
        }
        // print
        public void Print()
        {
            Console.WriteLine($"{ms} \t {hoten} \t {dtb} ");
        }
        //
        public override string ToString()
        {
            return ms + " " +hoten + " " +string.Format($"{dtb:f1}"); 
        }

        // Phwuong thức thiết lập Icomparable
        public int CompareTo( Text s )
        {
            if ( dtb > s.dtb )
            {
                return 1;
            }else if ( dtb == s.dtb ) 
            { 
                return 0;
            }
            return -1;
        }
    }
    class DS_SV
        {
        List<DS_SV> ds;
        int n;

        public DS_SV(string ms, string hoten, float dtb)
        {
            Ms = ms;
            Hoten = hoten;
            Dtb = dtb;
        }

        public string Ms { get; }
        public string Hoten { get; }
        public float Dtb { get; }

        // Khởi tạo mặc định
        //Nhập ds sv
        public void Nhap()
        {
            Console.Write("Nhập n:");
            n=int.Parse(Console.ReadLine());
            //Khởi tạo list
            ds = new List<DS_SV>();
            // Nhập các thành phần của ds
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập mã số sinh viên: ");
                string ms = Console.ReadLine();
                Console.Write("Nhập họ và tên: ");
                string hoten = Console.ReadLine();
                Console.Write("Nhập điểm trung bình");
                float dtb = Convert.ToSingle(Console.ReadLine());
                DS_SV ds1= new DS_SV (ms,hoten,dtb);
                ds.Add(ds1);
            }
        }

        public void Xoa()
        {
            ds.RemoveAt(1);
        }
        public void Print()
        {
            for(int i = 0;i < n;i++)
            {
                ds[i].Print();
            }
        }
        // xắp sếp
        public void XapXep()
        {
            ds.Sort();
        }
    }
    class DS_SinhVien
    {
        List<Text> ls;
        int n;
        public DS_SinhVien()
        {
            try
            {
                FileStream f = new FileStream("D:\\HĐT\\quoclam_63132195\\BT.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(f);

                n = int.Parse(rd.ReadLine());
                ls = new List<Text>(n);
                for(int i = 0; i < n; i++)
                {
                    string m = rd.ReadLine();
                    string ht = rd.ReadLine();
                    float d = float.Parse(rd.ReadLine());
                    Text s = new Text(m, ht, d);
                    ls.Add(s);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Xuat()
        {
            foreach(Text s in ls)
                //s.Print();
                Console.WriteLine(s.ToString());
        }
    }
}
