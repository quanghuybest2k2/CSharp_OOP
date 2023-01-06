using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    internal class Program
    {
        enum Menu
        {
            Thoat = 0,
            NhapTuFile = 1,
            Xuat = 2,
            NhapNgauNhien = 3,
            TimMax = 4,
            TimTheoMau = 5
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ////PhanSo ps = new PhanSo(6,7);
            ////ps.Xuat();
            ////ps.Nhap();
            ////ps.Xuat();
            //PhanSo a = new PhanSo(5,8);
            //PhanSo b = new PhanSo(9,7);
            //PhanSo ps = a.Cong(a, b);
            //ps.Xuat();
            //Console.ReadLine();
            MangPhanSo ds = new MangPhanSo();
            while (true)
            {
                Console.WriteLine($"Nhập {(int)Menu.Thoat} để thoát");
                Console.WriteLine($"Nhập {(int)Menu.NhapTuFile} để nhập từ file");
                Console.WriteLine($"Nhập {(int)Menu.Xuat} để đọc file");
                Console.WriteLine($"Nhập {(int)Menu.NhapNgauNhien} để nhập ngẫu nhiên");
                Console.WriteLine($"Nhập {(int)Menu.TimMax} để tìm phân số lớn nhất");
                Console.WriteLine($"Nhập {(int)Menu.TimTheoMau} để tìm theo mẫu");
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case Menu.Thoat:
                        return;
                    case Menu.NhapTuFile:
                        ds.NhapTuFile();
                        break;
                    case Menu.Xuat:
                        ds.Xuat();
                        break;
                    case Menu.NhapNgauNhien:
                        ds.NhapNgauNhien();
                        break;
                    case Menu.TimMax:
                        ds.TimMax();
                        break;
                    case Menu.TimTheoMau:
                        Console.Write("Nhập mẫu cần tìm: ");
                        int mau = int.Parse(Console.ReadLine());
                        ds.TimPhanSoCoMauLa(mau);
                        break;
                }
            }
        }
    }
}
