using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Bx, By,R;
            Console.WriteLine("Введите координаты B(x, y)\nВведите координаты Bx");
            Bx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координты By");
            By = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите радиус окружности");
            R = Convert.ToInt32(Console.ReadLine());
            if(Math.Pow(Bx,2)+Math.Pow(By,2)<=Math.Pow(R,2))
            {
                Console.WriteLine("Точки находятся в окружности");
            }
            else
            {
                Console.WriteLine("Точки не находятся в окружности");
            }
            Console.ReadKey();
        }
    }
}
