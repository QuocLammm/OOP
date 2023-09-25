using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void BT2_1()
        {
            // bài 2.1
            Point p1 = new Point(); // Tạo một điểm không tham số
            Console.Write("Nhap toa do x, y cua 1 diem :");
            short a = Convert.ToInt16(Console.ReadLine());
            short b = Convert.ToInt16(Console.ReadLine());

            Point p2 = new Point(a, b);

            // In ra thông tin tọa độ của hai điểm
            Console.Write("Diem p1 co toa do: ");
            p1.Print();
            Console.Write("Diem p2 co toa do:  ");
            p2.Print();

            // Tính và in ra khoảng cách giữa hai điểm
            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Khoang cach giua hai diem la: {distance}");
        }
        static void BT2_2()
        {
            Console.Write("Chu vi va dien tich :");
            Cirrcle c1 = new Cirrcle(1); // tạo đối tượng không tham số 
            Console.WriteLine("Chu vi: " + c1.GetPerimeter());
            Console.WriteLine("Dien tich: " + c1.GetArea());

            // Thay đổi bán kính
            Console.Write("Nhap ban kinh new: ");
            float a = float.Parse(Console.ReadLine());
            c1.Setradius(a);

            // Tính và in ra màn hình bán kính, chu vi hình tròn
            Console.WriteLine("Ban kinh new: " + c1.Getradius());
            Console.WriteLine("Chu vi : " + c1.GetPerimeter());
            Console.WriteLine("Dien tich : " + c1.GetArea());

            // Tạo đường tròn có tham số
            Cirrcle c2 = new Cirrcle();
            Console.Write("Nhap ban kinh thu 2: ");
            a = Convert.ToSingle(Console.ReadLine());
            // Tính và in ra màn hình chu vi, diện tích hình tròn
            Console.WriteLine("Chu vi new: " + c2.GetPerimeter());
            Console.WriteLine("Dien tich new: " + c2.GetArea());

        }
        static void BT2_3()
        {
            Chuoi c = new Chuoi();
            c.HienThi();
            c.ChuyenDong();
        }
        //bai 2.4
        static void BT2_4()
        {
            Adult a = new Adult();
            a.Print();
            a.Inc_Dec();

            Console.Write("Nhap ten cua 1 nguoi: ");
            string n = Console.ReadLine();
            Console.Write("Nhap can nang cua 1 nguoi: ");
            float w = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap chieu cao cua 1 nguoi: ");
            float h = Convert.ToSingle(Console.ReadLine());
            Adult a1 = new Adult(n, w, h);
            a1.Print();
            a1.Inc_Dec();
        }


        static void BT2_5()
        {
            // Thiết lập Encoding cho Console
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            // Nhập thông tin sinh viên
            Console.WriteLine("Nhập thông tin sinh viên:");
            Console.Write("Mã số: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Họ tên: ");
            string name = Console.ReadLine();
            Console.Write("Ngày sinh (dd/MM/yyyy): ");
            DateTime birthday = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Giới tính: (0 là nữ, 1 là nam): ");
            bool male = int.Parse(Console.ReadLine()) == 1;

            // Tạo đối tượng Student và xuất thông tin ra màn hình
            Student student = new Student(id, name, birthday, male);
            Console.WriteLine("Thông tin sinh viên vừa nhập:\t");
            student.Print();
            Console.ReadKey();
        }


        static void BT2_6()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Tạo đối tượng thời gian không tham số
            Time t1 = new Time();
            Console.WriteLine("Thời gian t1: " + t1.Hour + ":" + t1.Minute + ":" + t1.Second);
            t1.NextSecond();
            Console.WriteLine("Thời gian sau khi cộng thêm 1 giây: " + t1.Hour + ":" + t1.Minute + ":" + t1.Second);

            // Tạo đối tượng thời gian có tham số
            Time t2 = new Time(23, 59, 59);
            Console.WriteLine("Thời gian t2: ");
            t2.Show();
            t2.PreviousSecond();
            Console.WriteLine("Thời gian trước khi trừ đi 1 giây: ");
            t2.Show();
            Console.ReadKey();
        }

        static void BT2_7()
        {
            Console.WriteLine("Ket qua câu a: 0 + 0 = 0\t");
            Console.WriteLine("Ket qua câu b: 7 + 8 = 15\t");
            Console.WriteLine("Ket qua câu c: 3 * 6 = 18\t");
            Console.WriteLine("Ket qua câu d: 7 + 8 = 15\t");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            ///BT2_1();
            Console.WriteLine("\t");
            //BT2_2();
            Console.WriteLine("\t");
            BT2_3();
            Console.WriteLine("\t");
            BT2_4();
            Console.WriteLine("\t");
            BT2_5();
            Console.WriteLine("\t");
            BT2_6();
            Console.WriteLine("\t");
            BT2_7();
            Console.ReadKey();
        }
    }
}
