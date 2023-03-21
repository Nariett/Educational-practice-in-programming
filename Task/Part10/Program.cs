using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Введите A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bведите С");
            C = Convert.ToInt32(Console.ReadLine());
            if ((Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2)))
            {
                Console.WriteLine("Числа являются тройкой пифагора");
            }
            else
            {
                Console.WriteLine("Числа не являются тройкой пифагора");
            }
            Console.ReadKey();


        }
    }
}
