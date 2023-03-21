using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int x2 = 2;
            int Aq, Aa;
            Console.WriteLine("Введите координаты точек A(q,a)\nвведите Aq");
            Aq = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Aa");
            Aa = Convert.ToInt32(Console.ReadLine());
            if (Aq >= x1 && x2 >= Aa)
            {
                Console.WriteLine("Входит в данную область");
            }
            else
            {
                Console.WriteLine("Не входит в данную область");
            }
            Console.ReadKey();
        }
    }
}
