using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part63
{
    internal class Program
    {
        static object myLock = new object();
        public static int Million100 = 0;
        static void Main(string[] args)
        {
            int num = 0;
            TimerCallback tm = new TimerCallback(PrintMillion);
            Timer timer = new Timer(tm, num, 0, 50);
            for(int i = 0; i < 20;i++)
            {
                Thread x = new Thread(AddMillion);
                x.Start();
                Thread.Sleep(100);
                x.Abort();
            }
            if (Million100 == 100000000)
            {
                Console.WriteLine("Выполнено");
               
            }
            Console.ReadKey();
        }
        public static void AddMillion()
        {
            lock (myLock)
            {
                Million100 += 5000000;
            }
        }
        public static void PrintMillion(object o)
        {
            Console.WriteLine(Million100);
        }

    }
}
