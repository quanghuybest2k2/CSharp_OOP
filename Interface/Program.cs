using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void resetColor()
        {
            Console.ResetColor();
        }
        static void Color(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Color(ConsoleColor.Green);
            Console.Write("Nhập vào chiều dài: ");
            resetColor();
            Color(ConsoleColor.Yellow);
            float dai = float.Parse(Console.ReadLine());
            resetColor();
            Color(ConsoleColor.Green);
            Console.Write("Nhập vào chiều rộng: ");
            resetColor();
            Color(ConsoleColor.Yellow);
            float rong = float.Parse(Console.ReadLine());
            resetColor();
            Color(ConsoleColor.Green);
            HinhChuNhat hcn = new HinhChuNhat(dai, rong);
            Console.WriteLine($"Chu vi hình chữ nhật là: {hcn.TinhChuVi()}");
            Console.WriteLine($"Diện tích hình chữ nhật là: {hcn.TinhDienTich()}");
            resetColor();
            Console.ReadLine();
        }
    }
}
