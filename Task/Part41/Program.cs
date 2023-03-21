using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            string text2 = "";
            int counter = 0;
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == ':')
                {
                    counter++;
                    continue;
                }
                else
                {
                    text2 += sb[i];
                }
            }
            StringBuilder text = new StringBuilder(text2);
            Console.WriteLine(text+ " "+ counter);
            Console.ReadKey();
        }
    }
}
