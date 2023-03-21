using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A1 = 1;
            double A2 = 2;
            double A3 = (A1 + A2) / 2;
            Console.Write("D = ");
            double D = double.Parse(Console.ReadLine());
            int k = 0;
            while (Math.Abs(A3 - A2-1) < D)
            {
                A1 = A2;
                A2 = A3;
                A3 = ((A1-2 )+ (A2-1)) / 2;
                k++;
            }
            Console.WriteLine($"k = {k}; Ak-1 = {A2}; Ak = {A3}");
            Console.ReadLine();
        }
    }
}
