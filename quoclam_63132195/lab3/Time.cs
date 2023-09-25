using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;
        // khởi tạo không tham số
        public Time()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }
        // khởi tạo có tham số
        public Time(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
        // tính và trả về mốc time sau 1s
        public static Time operator++(Time t)
        {
            t.second++;
            if (t.second >= 60)
            {
                t.second = 0;
                t.minute++;
                if (t.minute >= 60)
                {
                    t.minute = 0;
                    t.hour++;
                    if (t.hour >= 24)
                    {
                        t.hour = 0;
                    }
                }
            }
            return t;
        }

        // tính và trả về time sau 1 giây

        public static Time operator--(Time t)
        {
            t.second--;

            if (t.second < 0)
            {
                t.second = 59;
                t.minute--;
                if (t.minute < 0)
                {
                    t.minute = 59;
                    t.hour--;
                    if (t.hour < 0)
                    {
                        t.hour = 23;
                    }
                }
            }
            return t;
        }

        public static Time operator +(Time t, int s)
        {
            for (int i = 0; i < s; i++)
            {
                t++;
            }
            return t;
        }
        public void Show()
        {
            Console.WriteLine("{0}:{1}:{2}", hour, minute, second);
        }
    }
}
