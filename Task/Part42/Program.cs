using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Part42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex t = new Regex(@"[1-6]{1}[0-3]{1}[0-9]{1}[0-1]{1}[0-9]{1}[0-9]{2}(A|B|C|E|M|H)\d{3}(GB|PB|BA|BI)\d");
            string tel = "5061204A502PB5, 1090299A090BI9";
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
