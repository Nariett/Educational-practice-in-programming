using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double x = 4;
            double y, p, t, a, b;
            Console.WriteLine("Введите a");
            a = Convert.ToDouble(Console.ReadLine());
            t = Math.Pow(x, 2) + Math.Pow(a, 2);
            p = Math.Pow(x, 2) - Math.Sqrt(Math.Abs(x));
            y = x * 3.14 * Math.Pow(p, 2) + Math.Pow(t, 5);
            Console.WriteLine($"y = {y}\np = {p}\nt = {t}");
            Console.ReadKey();
        }
    }
}
