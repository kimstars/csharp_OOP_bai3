using System;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nhập kích thước ma trận m x n: ");
            //Console.WriteLine("Nhập m : "); m = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập n : "); n = int.Parse(Console.ReadLine());

            Matran x = new Matran(1, 2);
            Matran y = new Matran(2, 3);
            x.Nhap();
            y.Nhap();
            Matran ketqua = x * y;
            ketqua.Xuat();
        }
    }
}
