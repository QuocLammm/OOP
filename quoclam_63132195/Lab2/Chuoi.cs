using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Chuoi
    {
        private string s;       // chuỗi S
        private int x, y;       // vị trí xuất hiện của chuỗi S
        // K tao kg tham so
        public Chuoi()
        {
            s = "chèo bẹn Như nghe!!";
            x = 5; y = 2;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        // kh tao co tham so
        public Chuoi(string s, int x, int y, int bg, int fg)
        {
            this.s = s;
            this.x = x;
            this.y = y;
            Console.BackgroundColor = (ConsoleColor)bg;
            Console.BackgroundColor = (ConsoleColor)fg;
        }
        // hiển thị 
        public void HienThi()
        {
            Console.Clear();
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.Write(s);
            Console.CursorVisible = false;
        }

        public void ChuyenDong()
        {
            ConsoleKeyInfo phim;
            do
            {
                HienThi();
                phim = Console.ReadKey(true);
                switch (phim.Key)
                {
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                }
            } while (phim.Key != ConsoleKey.Escape);
            // xử lí biên
            if (y <= 0)
            {
                y = Console.WindowTop;
                HienThi();
            }

        }
    }
}
