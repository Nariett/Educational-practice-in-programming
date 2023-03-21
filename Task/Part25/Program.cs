using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Part25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[19] {1,2,3,4,5,6,7,8,-1,0,0,0,0,0,0,0,0,0,0};
            int nigative = 0;
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                if (mas[i] < 0 )
                {
                    nigative = i;
                    break;
                }
            }
            if (nigative != 0)
            {  
                for(int i = 0; i < nigative;i++)
                {
                    sum += mas[i];
                }
                Console.WriteLine($"сумма равна = {sum}");
            }
            else
            {
                Console.WriteLine("В данном массиве нету отрицательных чисел или оно расположенно в первой ячейке");
            }
            Console.ReadKey();

        }
    }
}
