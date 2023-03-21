using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Part48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива ");
            sub mas = new sub(Convert.ToInt32(Console.ReadLine()));
            mas.Enter();
            Console.WriteLine("Введите размерность массива ");
            sub ma = new sub(Convert.ToInt32(Console.ReadLine()));
            ma.Enter();
            Console.WriteLine(mas.ToString());
            Console.WriteLine(ma.ToString());
            Console.WriteLine("Проверка что одна прогрессия больше другой");
            if (mas < ma)
            {
                Console.WriteLine("вторая прогрессия больше первой");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.WriteLine("Проверка что прогрессии равны");
            if (mas == ma)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            mas.decreasing();
            Console.WriteLine("Обработанный массив по убыванию \n"+mas.ToString());
            mas.increasing();
            Console.WriteLine("Обработанный массив по возрастанию \n" + mas.ToString());
            Console.WriteLine($"максимальное значение массива {mas.max()}");
            Console.WriteLine("введите число больше которого хотите вывести массив");
            mas.more(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("введите число меньше которого хотите вывести массив");
            mas.less(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
