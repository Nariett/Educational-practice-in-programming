using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Part47
{
    internal class line
    {
        public int x1, y1;
        public int x2, y2;
        public line()
        {
            x1 = 1;
            y1 = 2;
            x2 = 3;
            y2 = 4;
        }
        public line(int x1,int y1,int x2,int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public void length()
        {
            Console.WriteLine($"длина верктора равна {Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(x2, 2) + Math.Pow(y2, 2))}\nдлина удвоинного вектора равна {Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(x2, 2) + Math.Pow(y2, 2))*2} \n новые координаты x1 = {x1*2} \ny1 = {y1*2}\nx2 = {x2*2}\ny2 = {y2 * 2}");
        }
        public override string ToString()
        {
            return Convert.ToString($"Информация об векторе\nx1 = {x1}\ny1 = {y1}\nx2 = {x2}\ny2 = {y2}");
        }
        ~line()
        {
            Console.WriteLine("Память очищена");
            Console.ReadKey();
        }
    }
}
