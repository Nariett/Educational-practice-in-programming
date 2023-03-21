using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part62
{
    public static class ColoredConsole
    {
        public static void WriteLine(ConsoleColor color, String format, params object[] list)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(format, list);
            Console.ResetColor();
        }
        public static void Write(ConsoleColor color,String format,params object[] list)
        {
            Console.ForegroundColor = color;
            Console.Write(format, list);
            Console.ResetColor();
        }

    
    }
}
