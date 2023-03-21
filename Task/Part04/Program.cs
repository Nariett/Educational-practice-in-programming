using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Part04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, r, cylinder, cone;
            Console.WriteLine("Введите высоту");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус");
            r = Convert.ToDouble(Console.ReadLine());
            cylinder = 3.14 * Math.Pow(r, 2) * h;
            cone = (1.0 / 3.0) * 3.14 * Math.Pow(r, 2) * h;
            Console.WriteLine($"Объем цилиндра равен {cylinder} Объем конуса равен {cone}");
            Console.ReadKey();
        }
    }
}
