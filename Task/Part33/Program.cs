using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[16];
            Random rnd = new Random();
            for (int i = 0; i < mas.GetLength(0);i++)
            {
                mas[i] = rnd.Next(0,10);
            }
            int[,] cor = conv(mas);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(cor[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();

        }
        static int[,] conv(int[] mas)
        {
            Array.Sort(mas);
            int[,] masx = new int[4, 4];
            int count = 0;
            for(int i = 0; i < 4;i++)
            {
                for(int j = 0;j < 4;j++)
                {
                    masx[i,j] = mas[count];
                    count++;
                }
            }
            return masx;
        }
    }
}
