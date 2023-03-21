using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x, y;
            Console.WriteLine("Введите размеры кирпича a * b * c\nВведите a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размеры кипича x * y\nВведите x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToInt32(Console.ReadLine());
            if((a == x && b == y) | (b == x && a == y))
            {
                Console.WriteLine("Прохлдит при пенпедиклуярном расположении");
            }
            else
            {
                Console.WriteLine("Не прохоит при перпендикулярном расположении");
            }
            if ((b == x && c == y) || (c == x && b ==y))
            {
                Console.WriteLine("Проходит при параллельном расположении");
            }
            else
            {
                Console.WriteLine("Не проходит при параллельном расположении");
            }
            Console.ReadKey();
        }
    }
}
