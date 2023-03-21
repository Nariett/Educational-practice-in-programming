using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n <=0)
            {
                Console.WriteLine("Введено неверное число");
                Console.ReadKey();
            }
            double s = 0;
            for (int k = 1;k <= n;k++)
            {
                s += (Math.Pow(-1, k) * (Math.Pow(k, 3) - 27)) / (3*factorial(k + 2));
            }
            Console.WriteLine($"Результат равен {s}");
            Console.ReadKey();
        }
        static int factorial(int n)
        {
            if (n == 1) return 1;
            return n * factorial(n - 1);
        }
    }
    
}
