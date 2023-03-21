using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Part24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double i = -2.0;i<=2.2;i+=0.4)
            {
                if (i > 1)
                {
                    Console.WriteLine($"x = {i} f = {Math.Pow(Math.Log(i,5),Math.Abs(Math.Cos(i)))}");
                }
                if (i <= 0)
                {
                    Console.WriteLine($"x = {i} f = {Math.Pow(Math.Acos(i),4)}");
                }
            }
            Console.ReadKey();
        }
    }
}
