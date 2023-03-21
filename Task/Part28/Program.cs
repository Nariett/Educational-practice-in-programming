using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[7, 7];
            int maxr = 0;
            int maxi = 0;
            Random ran = new Random();
            for(int i = 0; i < mas.GetLength(0); i++)
            {
                for(int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = ran.Next(0,10);

                }
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + " ");
                    sum += mas[i, j];
                }
                if(sum > maxr)
                {
                    maxr = sum;
                    maxi = i;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Самая большая сумма в строке под номером {maxi}");
            Console.ReadKey();
        }
    }
}
