using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Matran
    {
        private int m, n;
        private int[,] arr;

        public Matran(int m, int n)
        {
            this.M = m;
            this.N = n;
            Arr = new int[m, n];
        }

        public int M { get => m; set => m = value; }
        public int N { get => n; set => n = value; }
        public int[,] Arr { get => arr; set => arr = value; }

        public void Nhap()
        {
            Console.WriteLine($"Nhập các phần tử của ma trận: {m}x{n}");
            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }

        }

        public void Xuat()
        {
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i,j]} ");
                    
                }
                Console.WriteLine();
            }

        }

        public int this[int i,int j]
        {
            get => (i < M && j < N) ? arr[i, j] : 0;
            set { if (i < M && j < N) arr[i,j] = value; }

        }

        public static Matran operator *(Matran x, Matran y)
        {
            Matran matrantich;
            if (x.N != y.M)
            {
                matrantich = new Matran(0, 0);
                Console.Write("Không thể nhân hai ma trận trên!!!");
                Console.Write("\nSo cot cua ma tran thu nhat phai bang so hang cua ma tran thu hai.");
                return matrantich;
            }
            else
            {
                matrantich = new Matran(x.M, y.N);
                for (int i = 0; i < x.M; i++)
                    for (int j = 0; j < y.N; j++)
                        matrantich[i, j] = 0;

                for (int i = 0; i < x.M; i++)    //hang cua ma tran thu nhat 
                {
                    for (int j = 0; j < y.N; j++)    //cot cua ma tran thu hai 
                    {
                        int sum = 0;
                        for (int k = 0; k < x.N; k++)
                            sum = sum + x[i, k] * y[k, j];
                        matrantich[i, j] = sum;
                    }
                }
                return matrantich; 

            }

        }

        public static Matran operator +(Matran x, Matran y)
        {
            Matran matrantong;
            if (x.M != y.M && x.N != y.M)
            {
                matrantong = new Matran(0, 0);
                Console.WriteLine("Không thể cộng hai ma trận");
                return matrantong;
            } 
            else
            {
                matrantong = new Matran(x.M, x.N);
                for (int i = 0; i < x.M; i++)
                {
                    for (int j = 0; j < x.N; j++)
                    {
                        matrantong[i, j] = x[i, j] + y[i, j];
                    }
  
                }
                return matrantong;
            }
        }

        public static Matran operator -(Matran x, Matran y)
        {
            Matran matrantong;
            if (x.M != y.M && x.N != y.M)
            {
                matrantong = new Matran(0, 0);
                Console.WriteLine("Không thể trừ hai ma trận");
                return matrantong;
            }
            else
            {
                matrantong = new Matran(x.M, x.N);
                for (int i = 0; i < x.M; i++)
                {
                    for (int j = 0; j < x.N; j++)
                    {
                        matrantong[i, j] = x[i, j] - y[i, j];
                    }

                }
                return matrantong;
            }
        }

        public static Matran operator +(Matran x, int y)
        {
            Matran matrantong;
            
           
                matrantong = new Matran(x.M, x.N);
                for (int i = 0; i < x.M; i++)
                {
                    for (int j = 0; j < x.N; j++)
                    {
                        matrantong[i, j] = x[i, j] + y;
                    }

                }
                return matrantong;
           
        }

        public static Matran operator -(Matran x, int y)
        {
            Matran matrantong;


            matrantong = new Matran(x.M, x.N);
            for (int i = 0; i < x.M; i++)
            {
                for (int j = 0; j < x.N; j++)
                {
                    matrantong[i, j] = x[i, j] - y;
                }

            }
            return matrantong;
        }

        public static Matran operator *(Matran x, int y)
        {
            Matran matrantong = new Matran(x.M, x.N);
            for (int i = 0; i < x.M; i++)
            {
                for (int j = 0; j < x.N; j++)
                {
                    matrantong[i, j] = x[i, j] * y;
                }

            }
            return matrantong;
        }


    }
}

 