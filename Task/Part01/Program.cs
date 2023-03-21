using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p, n, y, g;
            Console.WriteLine("Введите значение n");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение g");
            g = Convert.ToDouble(Console.ReadLine());
            p = n * Math.Sqrt(Math.Pow(y, 3) + 1.09 * g);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
