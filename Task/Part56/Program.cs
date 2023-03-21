using System;
using System.IO;
using System.Xml.Schema;

namespace Part56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double score = 0;
            int line = 0;
            using (StreamReader read = new StreamReader("Person.txt"))
            {
                while (!read.EndOfStream)
                {
                    string text = read.ReadLine();
                    string[] info = text.Split(' ');
                    score += Convert.ToInt32(info[2]);
                    line++;
                }
            }
            Console.WriteLine($"Средний балл по группе: {score / line}");
            using (StreamReader read = new StreamReader("Person.txt"))
            {
                while (!read.EndOfStream)
                {
                    string text = read.ReadLine();
                    string[] info = text.Split(' ');
                    if (Convert.ToInt32(info[2]) > score / line)
                    {
                        Console.WriteLine(text);
                    }
                }
            }
            Console.ReadKey();

        }
    }
}