using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Depositor test = new Depositor("абоба", new DateTime(2022, 12, 12),1000.5,15);
            test.show();
            int size = 2;
            Depositor[] a = new Depositor[size];
            a = test.Enter(size);
            PrintArray(a);
            Console.WriteLine(a[0][0] + "\n" + a[0][1] + "\n" + a[0][2]);
            a = test.CompareTo(a);
            PrintArray(a);
            Console.ReadKey();
        }
        static void PrintArray(Depositor[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i].show();
                Console.Write("\n");
            }
        }
    }
}
