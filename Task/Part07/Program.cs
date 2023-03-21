using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 0;
            int C = 0;
            Console.WriteLine("Результат 1 = " + ((-A | -B) & -C));
            Console.WriteLine("Результат 2 = " + ((-A | -B) & (A|B)));
            Console.WriteLine("Результат 3 = " + (A & B | A & C | -C));
            Console.ReadKey();
        }
    }
}
