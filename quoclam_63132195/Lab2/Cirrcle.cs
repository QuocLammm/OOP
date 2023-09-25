using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Cirrcle
    {
        private float radius;
        public Cirrcle()
        {
            radius = 1.0f;
        }
        public Cirrcle(float r)
        {
            radius = r;
        }
        // phương thức truy nhập vào dữ liêu
        public float Getradius()
        {
            return radius;
        }
        public void Setradius(float r)
        {
            radius = r;
        }
        // Tính chu vi đường tròn
        public float GetPerimeter()
        {
            return 2 * (float)Math.PI * radius;
        }
        // Tính diện tích đường tròn
        public float GetArea()
        {
            return (float)Math.PI * (float)Math.Pow(radius, 2);
        }
    }
}
