using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] array = {'[', 'T', 'E', 'S', 'T',']',' ', '[', 'T', 'E', 'S', 'T', ']' };
            Console.WriteLine(array);
            int f = 0;
            int s = 0;
            for(int i = 0; i < array.Length;i++)
            {
                if (array[i] == '[')
                {
                    f++;
                }
                if (array[i] == ']')
                {
                    s++;
                }
            }
            if(s == f)
            {
                Console.WriteLine("Число открывающих знаков препинания и закрывающих равно");
            }
            else
            {
                Console.WriteLine($"Число открывающих знаков препинания {f} и закрыввающих равно {s}");
            }
            Console.ReadKey();
        }
    }
}
