using System;
using System.Threading;

namespace Part62
{
    internal class Program
    {
        static object myLock = new object();
        static void Main(string[] args)
        {
            PrintRed(0);
            PrintGreen(0);
            Console.Read();

        }

        static void PrintRed(object o)
        {
            lock (myLock)
            {
                int num = 0;
                TimerCallback tm = new TimerCallback(
                (state) => { ColoredConsole.WriteLine(ConsoleColor.Red, "Red"); }
                );
                Timer timer = new Timer(tm, num, 0, 200);
            }

        }
        static void PrintGreen(object o)
        {
            int num = 0;
            TimerCallback tm = new TimerCallback(
            (state) => { ColoredConsole.WriteLine(ConsoleColor.Green, "Green"); }
            );
            Timer timer = new Timer(tm, num, 0, 200);
        }
    }
}
