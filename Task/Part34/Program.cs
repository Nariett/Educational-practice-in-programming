using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pro(x));
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            Console.WriteLine(clear(text));
            Console.ReadKey();
        }
        static bool pro(int x)
        {
            bool rez = true;
            for(int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    rez = false;
                    break;
                }
            }
            return rez;
        }
        static string clear(string text)
        {
            string textcor = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (i != text.Length - 1)
                {
                    if (text[i] == ' ' && text[i + 1] == ' ')
                    {
                        continue;
                    }
                }
                if (i + 1 == text.Length)
                {
                    if (text[i] == ' ')
                    {
                        continue;
                    }
                }
                textcor += text[i];
            }
            return textcor;
        }
    }
}
