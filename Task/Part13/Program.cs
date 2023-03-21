using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координыт точки A(q, a)\nВведите координаты q");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты a");
            int a = Convert.ToInt32(Console.ReadLine());
            if(q <= 100)
            {
                Console.Write("Северо-");
                if (a <= 100) Console.Write("Запад");
                else Console.Write("Восток");
            }
            else
            {
                Console.Write("Юго-");
                if (a <= 100) Console.Write("Запад");
                else Console.Write("Восток");
            }
            Console.ReadKey();
        }
    }
}
