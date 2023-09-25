using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void BT3_1()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Phanso ps1 = new Phanso();
            Console.Write("Nhập tử số và mẫu số của 1 phân số :");
            int ts = int.Parse(Console.ReadLine());
            int ms = int.Parse(Console.ReadLine());
            Phanso ps2 = new Phanso(ts, ms);
            Console.Write("Phân số thứ 1: ");
            ps1.Xuat();
            Console.Write("Phân số thứ 2: ");
            ps2.Xuat();
            Phanso tong = new Phanso();
            tong = ps1 + ps2;
            Console.Write("Tổng 2 phân số: ");
            tong.Xuat();
            Phanso tru = new Phanso();
            tru = ps1 - ps2;
            Console.Write("Hiệu 2 phân số: ");
            tru.Xuat();
            Phanso tich = new Phanso();
            tich = ps1 * ps2;
            Console.Write("Tích 2 phân số: ");
            tich.Xuat();
            Phanso thuong = new Phanso();
            thuong = ps1 / ps2;
            Console.Write("Thương 2 phân số: ");
            thuong.Xuat();
        }
        //-------------------Bài 3.2--------------------------
        static void BT3_2()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            VeMB[] ds;
            byte n;
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

            //sap xep 
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (ds[i] < ds[j])//(ds[i].TinhGiaVe() < ds[j].TinhGiaVe())
                    {
                        VeMB ve = new VeMB();
                        ve = ds[i];
                        ds[i] = ds[j];
                        ds[j] = ve;
                    }
            //xuat n ve ra man hinh
            foreach (VeMB ve in ds)
                ve.Xuat();

            //tinh tong tien n ve
            float s = 0;
            foreach (VeMB ve in ds)
                s = s + ve;//s + ve.TinhGiaVe();
            Console.WriteLine("Tiền vé TB: {0}", s / n);

            //dem so luong ve loai Business
            byte c = 0;
            foreach (VeMB ve in ds)
                if (ve.Loaive == "Business")
                    c++;
            Console.WriteLine("Số loại vé Business: {0}", c);
        }
        //---------------------------------Bài 3.2 ------ cách 2 ---------------------
        static void BT3_2_C2()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            DS_VeMB ds = new DS_VeMB();
            ds.Nhap();
            ds.SapXep();
            ds.XuatDS();
            ds.TinhTB();
            ds.DemLoaiVe();
        }

        //--------------------------------------------Bài 3.3---------------------------------
        static void BT3_3()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            HoaDonHocPhi dl = new HoaDonHocPhi();
            dl.Nhap();
            Console.WriteLine("\t");
            dl.Xuat();
        }

        // -----------------------------------Bài 3.4-----------------------------
        static void BT3_4()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Time t1 = new Time();
            ++t1;
            Console.Write("Thời gian sau 1 giây: ");
            t1.Show();

            Console.Write("Nhập giờ: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Nhập phút: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhập giây: ");
            int s = int.Parse(Console.ReadLine());
            Time t2 = new Time(h, m, s);
            --t2;
            Console.Write("Thời gian trước 1 giây: ");
            t2.Show();

            Console.Write("Nhập vào số giây cộng thêm: ");
            int x = int.Parse(Console.ReadLine());
            Time t3 = t1 + x;
            Console.Write("Thời gian sau khi cộng thêm {0} giây: ", x);
            t3.Show();
        }
        // --------------------------------------------Bài 3.5-----------------------------------
        static void BT3_5()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập số học viên n (2<n<30): ");
            int n = int.Parse(Console.ReadLine());

            HocVien[] listHocVien = new HocVien[n];

            // Nhập thông tin cho n học viên
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin học viên thứ {i + 1}:");
                listHocVien[i] = new HocVien();
                listHocVien[i].NhapThongTin();
                Console.WriteLine();
            }

            // Xuất thông tin danh sách học viên
            Console.WriteLine("Danh sách học viên:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Học viên thứ {i + 1}:");
                listHocVien[i].Xuat();
                Console.WriteLine();
            }

            // Tính và xuất tổng số tiền học phí của n học viên
            double tongTienHocPhi = 0;
            foreach (var hocVien in listHocVien)
            {
                tongTienHocPhi += hocVien.TinhTienHocPhi();
            }
            Console.WriteLine($"Tổng tiền học phí của {n} học viên là : {tongTienHocPhi}");
            Console.ReadKey();
        }
        //-----------------------------------Bài 3.5------ cách 2------------------------------------------- 
        static void BT3_5_C2()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            DS_HocVien ds= new DS_HocVien();
            ds.Nhap();
            ds.XuatKQ();
            ds.TinhTienHocPhi();
        }
        //---------------------------------Bài 3.6-------------------------------------------
        static void BT3_6()
        {
            // thiết lập tiếng việt
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Câu a đáp án = 9.5");
            Console.WriteLine("Câu b lỗi tham chiếu ");
            Console.WriteLine(" Câu c đáp án là: Acer    1       7.5");
            Console.WriteLine(" Câu d đáp án là: Dell Latitude E7440     1       7.5");
        }
        static void Main(string[] args)
        {
            // thiết lập tiếng việt
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Bài 1: \t");
            //BT3_1();
            Console.WriteLine("Bài 2: \t");
            //BT3_2();
            Console.WriteLine("Bài 2 cách 2: \t");
            //BT3_2_C2();
            Console.WriteLine("Bài 3: \t");
            BT3_3();
            Console.WriteLine("Bài 4: \t");
           // BT3_4();
            Console.WriteLine("Bài 5: \t");
            //BT3_5();
            Console.WriteLine("Bài 5 cácch 2: \t");
            //BT3_5_C2();
            Console.WriteLine("Bài 6: \t");
            //BT3_6();
            Console.ReadKey();
        }
    }
}
