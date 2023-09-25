using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Point
    {
        private double x;
        private double y;
        public Point()                       // Khởi tạo không tham số//
        {
            x = 0; y = 0;
        }
        public Point(double x, double y) //Khởi tạo có tham số (tên giống hoặc khác đều được//
        {
            this.x = x;
            this.y = y;
        }
        public void Print()               // in ra màn hình tọa độ điểm
        {
            Console.WriteLine($"({x}, {y})");
        }
        // ----------------tính khoảng cách--------//
        public double DistanceTo(Point p)
        {
            double dx = x - p.x;
            double dy = y - p.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
