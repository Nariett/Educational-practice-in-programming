using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Part30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер массива m");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int [n,m];
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        A[i, j] = p;
                        p++;
                        break;
                    }
                    else
                    {

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
