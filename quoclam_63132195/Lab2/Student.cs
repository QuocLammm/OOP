using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student
    {
        private int id;
        private string name;
        private DateTime birthday;
        private bool male;

        // Khởi tạo không tham số
        public Student()
        {
            id = 0;
            name = "";
            birthday = DateTime.Now;
            male = true;
        }

        // Khởi tạo có tham số
        public Student(int id, string name, DateTime birthday, bool male)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.male = male;
        }

        // Khởi tạo sao chép
        public Student(Student hs)
        {
            this.id = hs.id;
            this.name = hs.name;
            this.birthday = hs.birthday;
            this.male = hs.male;
        }

        // Xuất thông tin sinh viên ra màn hình
        public void Print()
        {
            Console.WriteLine("Mã số sinh viên: {0}", id);
            Console.WriteLine("Họ tên sinh viên: {0}", name);
            Console.WriteLine("Giới tính: {0}", male ? "Nam" : "Nữ");
            Console.WriteLine("Tuổi: {0}", GetAge());
        }

        // Tính tuổi của sinh viên
        private int GetAge()
        {
            int age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
}
