using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d, k, a, b, y,x;
            Console.WriteLine("Введите значение k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            d = Math.Pow(k, -Math.Asin(x)) - a*Math.Sqrt(6) - Math.Cos(3*a*b) / Math.Pow(Math.Sin(a*Math.Asin(x)+Math.Log10(y)), 2);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
