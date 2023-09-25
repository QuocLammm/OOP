using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Shape
    {
        string name;
        public Shape(string name)
        {
            this.name = name;
        }

        public virtual double Perimeter()
        {
            return 0;
        }

        public virtual double Area()
        {
            return 0;
        }

        public void Print()
        {
            Console.WriteLine("Tên: {0}", name);
            Console.WriteLine("Chu vi: {0}", Perimeter());
            Console.WriteLine("Diện tích: {0}", Area());
        }
    }

    class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Perimeter()
        {
            return a + b + c;
        }

        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

    class Rectangle : Shape
    {
        private double width, height;

        public Rectangle(string name, double width, double height) : base(name)
        {
            this.width = width;
            this.height = height;
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }

        public override double Area()
        {
            return width * height;
        }
    }
}
