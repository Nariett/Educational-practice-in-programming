using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sh(x)*Math.Tan(x+1)-Math.Pow(Math.Tan(2+sh(x-1)),2));
            Console.ReadKey();
        }
        static double sh(int x)
        {
            return (Math.Exp(x) - Math.Exp(-x))/2;
        }
    }
}
