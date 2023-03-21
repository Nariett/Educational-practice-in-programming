using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double i = 1.1; i <= 2.9; i += 0.1)
            {
                Console.WriteLine($"x = {i} y = {Math.Pow(i, 3) - 6 * Math.Pow(i, 2) + 2}");
            }
            Console.ReadKey();
        }
    }
}
