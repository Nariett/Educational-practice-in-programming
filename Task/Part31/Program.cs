using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Выволненная при помощи обычной функции {fib(x)}");
            Console.WriteLine($"Выволненная при помощи рекурсии {fib2(x)}");
            Console.ReadKey();
        }
        static int fib(int x)
        {
            int result = 0;
            int b = 1;
            int tmp;
            for (int i = 0; i < x; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }
            return result;
        }
        static int fib2(int x)
        {
            if (x == 0 || x == 1) return x;

            return fib2(x - 1) + fib2(x - 2);
        }
    }
}
