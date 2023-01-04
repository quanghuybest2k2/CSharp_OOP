using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //PhanSo ps = new PhanSo(6,7);
            //ps.Xuat();
            //ps.Nhap();
            //ps.Xuat();
            PhanSo a = new PhanSo(5,8);
            PhanSo b = new PhanSo(9,7);
            PhanSo ps = a.Cong(a, b);
            ps.Xuat();
            Console.ReadLine();
        }
    }
}
