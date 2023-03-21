using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Part45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Regex regex = new Regex(@"[0-3]{1}[0-9]{1}/((1)[0-2]{1}|(0)[1-9]{1})/((1)(8|9)[0-9]{2}|(2)(0)[0-9]{2}|(2)(1)(0){2})");
            StreamReader f = new StreamReader("C:\\Users\\samsi\\OneDrive\\Рабочий стол\\text.txt");
            while (!f.EndOfStream)
            {
                string s = f.ReadLine();
                MatchCollection matches = regex.Matches(s);

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        string[] q = s.Split('/');
                        int d = Convert.ToInt32(q[0]);
                        int m = Convert.ToInt32(q[1]);
                        int h = Convert.ToInt32(q[2]);
                        if (DateTime.IsLeapYear(h) == true & m == 2)
                        {
                            Console.WriteLine(match.Value+" висококсный год");x++;
                        }
                        else
                        {
                            Console.WriteLine(match.Value); x++;
                        }
                    }
                }
            }
            f.Close();

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
