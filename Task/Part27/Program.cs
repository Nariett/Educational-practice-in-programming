using System;

namespace Part27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[5] { 0, 2, 4, 6, 8};
            int rez = mas[1] - mas[0];
            bool pro = true;
            for (int i =0;i<mas.GetLength(0)-1 ; i++)
            {
                if (mas[i+1] - mas[i] == rez)
                {
                    pro = true;
                    continue;
                }
                else
                {
                    pro = false;
                    break;
                }
            }
            if ( pro = true)
            {
                Console.WriteLine($"Образуется прогрессия с шагом {rez}");
            }
            else
            {
                Console.WriteLine("Прогрессия не образуется");
            }


            Console.ReadKey();
        }
    }
}
