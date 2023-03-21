using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 24;
            for (int i = 1826;i<=2022;i++)
            {
                price = price + (price * 0.06);
            }
            Console.WriteLine($"Результат равен: {price}");
            Console.ReadKey();
        }
    }
}
