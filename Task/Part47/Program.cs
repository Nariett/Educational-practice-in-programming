using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            line AB = new line();
            line AC = new line(2,3,4,5);
            AB.length();
            Console.WriteLine(AB.ToString());
            Console.ReadKey();
        }
    }
}
