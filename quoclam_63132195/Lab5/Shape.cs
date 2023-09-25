using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    abstract class Shape
    {
        protected string name;
        public Shape()
        {
            name = "HCN";
        }
        public Shape(string n="HCN")
        {
            name = n;
        }
        public abstract float Area();
    }
    public interface IPaint
    {
        float Price { get; set; }// thuộc tính đơn giá
        float Cost();// phương thức tính chi phí vé
    }
    class Rectangle : Shape, IPaint, IComparable<Rectangle>
    {
        float d, r;
        float price;

        public float Price { get => price; set => price = value; }
        // khởi tạo
        public Rectangle(float d = 3, float r = 4, float p = 7, string n ="HCN") : base(n)
        {
            this.d = d;
            this.r = r;
            price = p;
        }

        // tính diện tích
        public override float Area()
        {
            return d * r;
        }
        // tính chi phí
        public float Cost()
        {
            return price * Area();
        }
        // xuất thông tin
        public void Print()
        {
            Console.WriteLine($"{name}, Diện tích:{Area()}\t Chi phí: {Cost()}");
        }
        // phương thức IComparable
        public int CompareTo(Rectangle other)
        {
            if (this.Cost() < other.Cost()) return 1;
            else if (this.Cost() == other.Cost()) return 0;
            else return -1;
        }
    }
    // danh sách
    public class List_Rec
    {
        List<Rectangle> ds;
        int n;
        // khởi tạo
        //Nhập n hình chữ nhật
        public void Input()
        {
            Console.Write("Nhập số lượng hình chữ nhật:");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 30)
            {
                Console.WriteLine("Nhập lại số lượng hình chữ nhật:");
            }
            // khởi tạo
            ds = new List<Rectangle>();
            // nhập n phần tử trong ds
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập chiều dài, chiều rộng hình thứ {0}:", i + 1);
                float d = float.Parse(Console.ReadLine());
                float r = float.Parse(Console.ReadLine());
                Rectangle rc = new Rectangle(d, r);
                ds.Add(rc);
            }
        }
        // xắp xếp giảm dần
        public void Sort()
        {
            ds.Sort();
        }
        // xóa HCN đầu tiên có S < x
        public void Delete()
        {
            Console.Write("Nhập diện tích cần xóa:");
            float x = float.Parse(Console.ReadLine());
            foreach (Rectangle rec in ds)
                if (rec.Area() < x)
                {
                    ds.Remove(rec);
                    break;
                }
        }
        // thêm 1 HCN vào vị trí i
        public void Add()
        {
            Console.Write("Nhập bị trí cần thêm:");
            int i = int.Parse(Console.ReadLine());
            // tạo đối tượng cần thêm vào list
            Console.Write("Nhập chiều dài, chiều rộng của hình cần thêm:");
            float d = float.Parse(Console.ReadLine());
            float r = float.Parse(Console.ReadLine());
            Rectangle rc = new Rectangle(d, r);
            if (i >= 0 && i < ds.Count)
                ds.Insert(i, rc);
            else if (i < 0)
                ds.Insert(0, rc);
            else
                ds.Add(rc);
        }
        // tính tổng chi phí
        public float Sum_Cost()
        {
            float s = 0;
            s = ds.Sum(rec => rec.Cost());
            return s;
        }


        // xuất danh sách
        public void Print()
        {
            foreach (Rectangle rc in ds)
                rc.Print();
        }
    }
}
