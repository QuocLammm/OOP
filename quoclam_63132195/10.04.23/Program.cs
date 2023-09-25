using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._04._23
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            DS_SinhVien ds=new DS_SinhVien();
            ds.Xuat();
            //VD_File();
            Console.ReadKey();
        }
    }
}
