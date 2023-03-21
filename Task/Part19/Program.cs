using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 1000 && n <= 9999) Console.WriteLine($"Число равно {(n % 100) / 10}");
            else if (n <= 999 && n >= 100) Console.WriteLine($"Число равно {(n % 100) / 10}");
            else if (n >= 10 && n <= 99) Console.WriteLine($"Число равно {n / 10}");
            Console.ReadKey();
        }
    }
}
