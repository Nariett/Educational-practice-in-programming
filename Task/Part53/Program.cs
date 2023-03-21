using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part53
{
    internal class Program
    {
        class Product
        {
            public delegate void ProductDel(string message);
            public event ProductDel Notify;
            public Product(int price) => Price = price;
            public int Price { get; private set; }
            public void Up(int price)
            {
                Notify?.Invoke($"Цена товара увеличина.\nЦена товара {price}");
            }
            public void Sell(int price)
            {
                if (Price >= price)
                {
                    Price -= price;
                    Notify?.Invoke($"Списанная сумма: {price}");
                    Notify?.Invoke("Товар куплен");
                }
                else
                {
                    Notify?.Invoke($"Нехватает. Ваш баланс: {Price}");
                }
            }
        }
        static void Main(string[] args)
        {
            Product prod = new Product(100);
            prod.Notify += DisplayMessage;
            prod.Up(50);
            Console.WriteLine($"Сумма на счете: {prod.Price}");
            prod.Sell(50);
            Console.WriteLine(" ");
            prod.Up(80);
            Console.WriteLine($"Сумма на счете: {prod.Price}");
            prod.Sell(80);
            void DisplayMessage(string message) => Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
