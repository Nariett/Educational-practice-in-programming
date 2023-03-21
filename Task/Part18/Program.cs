using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int pro = 1;
            Console.WriteLine("Введите значение m");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение n");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = m;i <=n;i++)
            {
                if(i%2==0)
                {
                    pro *= (int)Math.Pow(i,2);
                }
            }
            Console.WriteLine($"Результат равен: {pro}");
            Console.ReadKey();
            
        }
    }
}
