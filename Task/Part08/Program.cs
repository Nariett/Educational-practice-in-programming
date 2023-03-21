using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Введите стаж");
            year = Convert.ToInt32(Console.ReadLine());
            if(year >=5 & year < 10)
            {
                Console.WriteLine("Надбавка 2%");
            }
            if(year >= 10 & year <= 20)
            {
                Console.WriteLine("Надбавка 10%");
            }
            Console.ReadKey();
        }
    }
}
