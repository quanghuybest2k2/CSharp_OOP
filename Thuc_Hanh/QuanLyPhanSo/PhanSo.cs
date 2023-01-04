using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    internal class PhanSo
    {
        public int tu;
        public int mau;
        // khoi tao mac dinh, new PhanSo() khong can tham so
        public PhanSo()
        {
            this.mau = 0;
        }
        // khoi tao co tham so
        public PhanSo(int t, int m)
        {
            this.tu = t;
            this.mau = m;
        }
        public void Nhap()
        {
            Console.Write("Nhập tử: ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu: ");
            mau = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"{tu}/{mau}");
        }
        public PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.mau + b.tu * a.mau;
            kq.mau = a.mau * b.mau;
            return kq;
        }
    }
}
