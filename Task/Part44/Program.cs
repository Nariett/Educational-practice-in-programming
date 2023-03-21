using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Part44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex t = new Regex(@"\d");
            string tel = "Кот весил 7 кг и был размером 60 см";
            Match tels = t.Match(tel);
            while (tels.Success)
            {
                Console.Write(tels+ " ");
                tels = tels.NextMatch();
                
            }
            Console.ReadKey();
        }
    }
}
