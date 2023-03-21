using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            string[] ss = text.Split(' ', ',', '.');
            for (int i = 0; i < ss.Length; i++)
                if (i % 2 != 0) Console.Write("{0} ", ss[i]);
            Console.ReadKey();
        }
    }
}
