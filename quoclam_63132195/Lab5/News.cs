using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public interface Inews
    {
        string Id { get; set; }// mã tin tức
        string title { get; set; }//tiêu đề tin tức
        string author { get; set; }//tác giả
        void Display();
    }
    class News : Inews
    {

        public string Id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public DateTime Date { get; set; }// ngày đăng tin tức
        public string content { get; set; }//nội dung
        public List<float> avgRate { get; set; }

        // Khởi tạo không tham số
        public News()
        {
            Id = "ST11";
            title = "Lập trình hướng đối tượng";
            author = "Phạm Thị Kim Ngoan";
            Date = DateTime.Now;
            content = "Lập trình hướng đối tượng bằng C#....";
            avgRate = new List<float>();
        }
        // Có tham số
        public News(string id, string title, string author, DateTime date, string content)
        {
            Id = id;
            this.title = title;
            this.author = author;
            Date = date;
            this.content = content;
            avgRate = new List<float>();
        }
        // Hiển thị thông tin
        public void Display()
        {
            Console.Write($"\nMã tin tức:{Id}\n");
            Console.Write($"Tiêu đề tin tức:{title}\n");
            Console.Write($"Tác giả tin tức:{author}\n");
            Console.Write($"Ngày đăng tin tức:{Date}\n");
            Console.Write($"Nội dung tin tức:{content}\n");
            Console.Write($"\nĐiểm trung bình đánh giá:{Cal_Avg()}");
        }
        
        // trung bình cộng điểm đánh giá của người dùng cho tin tức
        public float Cal_Avg()
        {
            if (avgRate.Count == 0)
            {
                return 0;
            }
            float sum=0 ;
            foreach (var rate in avgRate)
            {
                sum += rate;
            }
            return sum / avgRate.Count;
        }
    }
    class ListNews
    {
        public int n { get; set; }
        public List<News> ds { get; set; }

        public ListNews()
        {
            ds = new List<News>();
        }
        // thêm 
        public void Add()
        {
            ListNews ds = new ListNews();
            ds.Input();
            Console.WriteLine("News added successfully!");
        }
        public void Input()
        {
            Console.WriteLine("\nNhập số lượng tin tức: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thông tin thứ " + (i + 1) + ":");
                News news = new News();
                Console.Write("\nMã tin tức: ");
                news.Id =Console.ReadLine();
                Console.Write("Tiêu đề: ");
                news.title = Console.ReadLine();
                Console.Write("Tác giả: ");
                news.author = Console.ReadLine();
                Console.Write("Ngày đăng tin (dd/mm/yyyy): ");
                news.Date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Nội dung: ");
                news.content = Console.ReadLine();
                Console.Write("Số người đánh giá: ");
                int numberOfRatings = int.Parse(Console.ReadLine());
                List<float> avgRate = new List<float>();
                for (int j = 0; j < numberOfRatings; j++)
                {
                    Console.Write($"Điểm đánh giá người thứ {j + 1}: ");
                    float rating = float.Parse(Console.ReadLine());
                    avgRate.Add(rating);
                }
                ds.Add(news);
            }
        }

        public void Output()
        {
            Console.WriteLine("Danh sách tin tức:");
            foreach (News news in ds)
            {
                news.Display();
                Console.WriteLine();
            }
        }
        public void Avg_Rate()
        {
            foreach (News news in ds)
            {
                news.Display();
                float avg=news.Cal_Avg();
                Console.WriteLine($"\nĐiểm trung bình: {avg}");
                Console.WriteLine();
            }
        }
    }
}
