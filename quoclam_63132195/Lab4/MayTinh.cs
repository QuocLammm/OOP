using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class MayTinh
    {
        public abstract class Computer
        {
            protected string nhanhieu;
            protected int ram;
            protected int bonho;
            protected double gianhap;
            // Khởi tạo mặc định không tham số
            public Computer()
            {
                nhanhieu = "MSI";
                ram = 8;
                bonho = 256;
                gianhap = 20000;
            }
            public Computer(string nhanHieu, int ram, int boNho, double giaNhap)
            {
                this.nhanhieu = nhanHieu;
                this.ram = ram;
                this.bonho = boNho;
                this.gianhap = giaNhap;
            }

            public virtual void NhapThongTin()
            {
                Console.WriteLine("Nhập thông tin máy :");
                Console.Write("Nhãn hiệu: ");
                nhanhieu = Console.ReadLine();
                Console.Write("RAM (GB): ");
                ram = int.Parse(Console.ReadLine());
                Console.Write("Bộ nhớ (GB): ");
                bonho = int.Parse(Console.ReadLine());
                Console.Write("Giá nhập: ");
                gianhap = double.Parse(Console.ReadLine());
            }

            public abstract double TinhGiaBan();

            public virtual void XuatThongTin()
            {
                Console.WriteLine("Xuất Thông tin :");
                Console.WriteLine("Nhãn hiệu: " + nhanhieu);
                Console.WriteLine("RAM (GB): " + ram);
                Console.WriteLine("Bộ nhớ (GB): " + bonho);
                Console.WriteLine("Giá bán: " + TinhGiaBan());
            }
        } 
    
        public class Laptop : Computer
        {
            protected double trongLuong;
            // Khởi tạo không tham số
            public Laptop()
            {
                trongLuong = 2.5;
            }

            public Laptop(string nhanhieu, int ram, int bonho, double gianhap, double trongLuong)
                : base(nhanhieu, ram, bonho, gianhap)
            {
                // Khởi tạo có tham số
                this.trongLuong = trongLuong;
            }

            public override void NhapThongTin()
            {
                base.NhapThongTin();
                Console.Write("Nhập trọng lượng (kg): ");
                trongLuong = double.Parse(Console.ReadLine());
            }

            public override double TinhGiaBan()
            {
                if (trongLuong >= 2)
                {
                    return gianhap + gianhap * 0.15;
                }
                else
                {
                    return gianhap + gianhap * 0.2;
                }
            }
            public override void XuatThongTin()
            {
                base.XuatThongTin();
                Console.WriteLine("Trong luong: {0}", trongLuong);
            }
        }
        public class MacBook : Computer
        {
            protected string loai;
            //Khởi tạo có tham số
            public MacBook()
            {
                loai = "MacBook Pro 13 inch";
            }
            //Khởi tạo không tham số
            public MacBook(string loai, string nhanhieu, int ram, int bonho, double gianhap) : base(nhanhieu, ram, bonho, gianhap)
            {
                this.loai = loai;
            }
            public override void NhapThongTin()
            {

                Console.Write("Nhập loại MacBook : (MacBook Air, MacBook Pro 13 inch, MacBook Pro 16 inch) ");
                loai = Console.ReadLine();
                base.NhapThongTin();
            }

            public override double TinhGiaBan()
            {
                if (loai == "MacBook Air")
                    return gianhap + gianhap * 0.5;
                else if (loai == "MacBook Pro 13 inch")
                    return gianhap + gianhap * 0.8;
                else
                    return gianhap * gianhap;
            }
            public override void XuatThongTin()
            {
                base.XuatThongTin();
            }
        }
    }
}