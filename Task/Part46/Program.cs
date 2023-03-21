using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point AB = new Point();
            AB.Enter();
            Console.WriteLine(AB.ToString());
            AB.per();
            Console.ReadKey();
        }
    }
}
