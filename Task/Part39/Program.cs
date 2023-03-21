using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст без пробелов");
            string text = Console.ReadLine();
            string text2 = "";
            for (int i = 0; i < text.Length; i++)
            {
                text2 += text[i] + " ";
            }
            Console.WriteLine(text2);
            Console.ReadKey();
        }
    }
}
