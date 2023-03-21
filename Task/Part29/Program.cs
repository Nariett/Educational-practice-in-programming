using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[8,5];
            int sum = 0;
            Random rnd = new Random();
            for(int i = 0; i < mas.GetLength(0); i ++)
            {
                for(int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 10);
                }
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j]);
                }
                Console.Write("\n");
            }
            for (int i = 0; i < mas.GetLength(0);i++)
            {
                sum+=mas[i, 1];
            }
            int sum2 = 0;
            for (int i = 0; i < mas.GetLength(1);i++)
            {
                sum2 += mas[2, i];
            }
            Console.WriteLine($"Сумма 2 столбца равна {sum}");
            Console.WriteLine($"Сумма 3 строки равна {sum2}");
            Console.ReadKey();

        }
    }
}
