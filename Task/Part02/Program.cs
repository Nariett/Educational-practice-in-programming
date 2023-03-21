using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y, q, e;
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение q");
            q = Convert.ToDouble(Console.ReadLine());
            e = Math.Log10(0.7 * y + 2 * q) / (Math.Sqrt(3 * Math.Pow(y, 2) + 0.5 * y + 4));
            Console.WriteLine($"Результат программы: {e}");
            Console.ReadKey();
            

        }   
    }
}
