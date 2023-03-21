using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlTypes;

namespace Part59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты X1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты X2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты Y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты Y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты Z1");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты Z2");
            int z2 = Convert.ToInt32(Console.ReadLine());
            Suqare x = new Suqare(x1, x2, y1, y2,z1,z2);
            Console.WriteLine(x.Show());
            Console.WriteLine("Длина:" + x.Length());
            Console.WriteLine("Площадь:" + x.Square());
            XmlSerializer formatter = new XmlSerializer(typeof(Suqare));
            using (FileStream fs = new FileStream("circle.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, x);
                Console.WriteLine("Серелизация xml выполнена");
            }
            using (FileStream fs = new FileStream("circle.xml", FileMode.OpenOrCreate))
            {
                Suqare z = formatter.Deserialize(fs) as Suqare;
                Console.WriteLine($"X1: {z.x1} X2: {z.x2}\nY1: {z.y1} Y2: {z.y2}\nZ1: {z.z1} Z2: {z.z2}");
            }
            Console.ReadKey();
        }
    }
}
