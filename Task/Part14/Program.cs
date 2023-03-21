using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Part14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double a, b, c, y;
            y = 0;
            a = 2.2;
            b = 2.4;
            c = Math.Log10(b * x);
            if( x < a)
            {
                y = c * Math.Sin(Math.Pow(b, 2) * x) + b * Math.Log10(c * x + a);
            }
            if(a < x && a < b)
            {
                y = a + Math.Log10(b * x) - Math.Pow(Math.Sin(a + c * x), 2);
            }
            if( x >= b)
            {
                y = Math.Sqrt(Math.Cos(a + b * x)) + c * Math.Pow(x, 2);
            }
        }
    }
}
