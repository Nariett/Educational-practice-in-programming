using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rez = 1;
            Console.WriteLine("Введите число до которого хотите расчитать сумму");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s < 0 )
            {
                Console.WriteLine("Вы ввели отрицательное число");
                Console.ReadKey();
            }
            Console.WriteLine("Введите число x");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= s; i++)
            {
                int f = factorial(i);
                rez += Math.Pow((2 * x), i) / f;
            }
            Console.WriteLine($"Результат равен {rez}");
            Console.ReadKey();
        }
        static int factorial(int n)
        {
            if (n == 1) return 1;
            return n * factorial(n - 1);
        }
    }
}
