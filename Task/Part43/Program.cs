using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Part43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex t = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");//ip
            string tel = "314.213.455.222,34.213.45.2, 1.1.1.1";
            Match tels = t.Match(tel);
            while (tels.Success)
            {
                Console.WriteLine(tels);
                tels = tels.NextMatch();
            }
            Console.ReadKey();
        }
    }
}
