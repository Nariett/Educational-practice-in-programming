using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vector x = new vector(1, 2, 3, 4);
            Console.WriteLine($"Длина равна {x.Length()}");
            vector2 a = new vector2(1, 2, 3, 4, 10, 15);
            Console.WriteLine(a.ToString());
            Console.WriteLine($"Периметр равен {a.Per()}");
            Console.ReadKey();
        }
    }
}
