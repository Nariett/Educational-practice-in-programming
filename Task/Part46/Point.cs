using System;

namespace Part46
{
    internal class Point
    {
        int Ox;
        int Oy;
        public void Enter()
        {
            Console.WriteLine("Введите координаты Ox");
            this.Ox = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты Oy");
            this.Oy = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return Convert.ToString($"Информация о точках\nкоординаты Oy = {Oy}\nкоординаты Oy = {Oy}");
        }
        public void per()
        {
            Console.WriteLine($"перимерт прямоугольника равен = {2 * Ox + 2 * Oy}");
        }

    }
}
