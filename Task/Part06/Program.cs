using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Ax, Ay, Bx, By, Cx, Cy, AB, BC, CA, per;
            Console.WriteLine("Введите координаты A(x, y)\nВведите Ax");
            Ax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Ay");
            Ay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты B(x, y)\nВведите Bx");
            Bx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите By");
            By = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты C(x, y)\nВведите Cx");
            Cx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Cy");
            Cy = Convert.ToDouble(Console.ReadLine());
            AB = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2));
            BC = Math.Sqrt(Math.Pow(Cx - Bx, 2) + Math.Pow(Cy - By, 2));
            CA = Math.Sqrt(Math.Pow(Ax - Cx, 2) + Math.Pow(Ay - Cy, 2));
            per = AB + BC + CA;
            Console.WriteLine(per);
            Console.ReadKey();

        }
    }
}
