using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
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
            this.hour = h;
            this.minute = m;
            this.second = s;
        }
        // đóng gói thuộc tính
        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public int Second
        {
            get { return second; }
            set { second = value; }
        }
        //
        public void NextSecond()
        {
            second++;

            if (second >= 60)
            {
                second = 0;
                minute++;
                if (minute >= 60)
                {
                    minute = 0;
                    hour++;
                    if (hour >= 24)
                    {
                        hour = 0;
                    }
                }
            }
        }
        public void PreviousSecond()
        {
            second--;

            if (second < 0)
            {
                second = 59;
                minute--;
                if (minute < 0)
                {
                    minute = 59;
                    hour--;
                    if (hour < 0)
                    {
                        hour = 23;
                    }
                }
            }
        }
        public void Show()
        {
            Console.WriteLine($"{hour}:{minute}:{second}");
        }
    }
}
