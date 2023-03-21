using System;

namespace Part37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] mas = { 't', 's', 'e', 't' };
            for (int i = mas.Length-1; i >= 0; i--)
            {
                Console.Write(mas[i]);
            }
            Console.ReadKey();
        }
    }
}

