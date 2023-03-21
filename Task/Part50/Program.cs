using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номинал купюры");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во купюры");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите страну\n0 - РБ\n1 - Россия\n2 - Казахстан");
            Country country = (Country)Convert.ToInt32(Console.ReadLine());
            money rub = new money(value, amount, country);
            Console.WriteLine(rub.ToString());
            rub++;
            Console.WriteLine($"Увеличение значений\n{rub.ToString()}");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Введите значение на которое хотите увеличить кол-во");
            int x = Convert.ToInt32(Console.ReadLine());
            rub += x;
            Console.WriteLine(rub.ToString());
            Console.WriteLine("-----------------------");
            Console.WriteLine($"умешьненное значение ");
            rub--;
            Console.WriteLine(rub.ToString());
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Новое кол-во{rub.ToString()}");
            Console.WriteLine($"Поле Second не нулевое?");
            if (!rub == true)
            {
                Console.WriteLine($"Поле Second не нулевое");
            }
            else
            {
                Console.WriteLine($"Поле Second нулевое");
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Введите к чему хотите обратиться\n0 - First\n1 - Second");
            int get = Convert.ToInt32(Console.ReadLine());
            if(get == 0)
            {
                Console.WriteLine($"Номинал {rub[get]}");
            }
            else
            {
                Console.WriteLine($"Сумма {rub[get]}");
            }
            Console.WriteLine(rub.ToString());
            Console.WriteLine("-----------------------");
            Console.WriteLine("Введите сумму, которую вы хотите купить");
            int q = Convert.ToInt32(Console.ReadLine());
            rub.price(q);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Введите цену товара, который собираетесь покупать");
            int w = Convert.ToInt32(Console.ReadLine());
            rub.tovar(w);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Введите номинал");
            rub.f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------");
            Console.WriteLine("Введите кол-во");
            rub.s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(rub.ToString());
            Console.WriteLine("-----------------------");
            Console.WriteLine("Сумма равна");
            Console.WriteLine(rub.sum);
            Console.ReadKey();

         
        }
    }
}
