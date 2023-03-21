using System;
using System.Security.AccessControl;

namespace Part38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            string letter = "abcdefghijklmnopqrstuvwxyz";
            bool rez = false;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {
                    if (text[i] == letter[j])
                    {
                        rez = true;
                    }
                }
                if(rez == true)
                {
                    Console.WriteLine("В строке обнаруенны латинские символы");
                    break;
                }

            }


            Console.ReadKey();
        }
    }
}
