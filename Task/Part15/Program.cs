using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part15
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 0;
            Console.WriteLine("Выберите гостиницу для заселения:\n1) Курортная *****\n2) Верховина ****\n3) Гуцулка ***");
            int name = Convert.ToInt32(Console.ReadLine());
            switch (name)
            {
                case 1:
                    Console.WriteLine("Вы выбрали гостиницу Курортная\nВыберите кол-во комнат:\n1) 1комната без питания 1000гр\n2) 1 комната с питанием 1500гр\n3) 2 комнаты без питания 1500гр\n4) 2 2комнаты с питанием 2500гр ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x == 1)
                    {
                        Console.WriteLine("Вы выбрали 1 комнату без питанием 1000гр");
                        price += 1000;
                    }
                    else
                    {
                        if (x == 2)
                        {
                            Console.WriteLine("Вы выбрали 1 комнату c питанием 1500гр");
                            price += 1500;
                        }
                        else
                        {
                            if (x == 3)

                            {
                                Console.WriteLine("Вы выбрали 2 комнаты без питания 1500гр");
                                price += 1500;
                            }
                            else
                            {
                                Console.WriteLine("Вы выбрали 2 комнаты с питанием 1500гр");
                                price += 2500;
                            }
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали гостиницу Верховина\nВыберите кол-во комнат:\n1) 1комната без питания 600гр\n2) 1 комната с питанием 900гр\n3) 2 комнаты без питания 900гр\n4) 2 2 комнаты спитанием 1500гр");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y == 1)
                    {
                        Console.WriteLine("Вы выбрали 1 комнату без питанием 600гр");
                        price += 600;
                    }/////////////
                    else
                    {
                        if (y == 2)
                        {
                            Console.WriteLine("Вы выбрали 1 комнату c питанием 900гр");
                            price += 900;
                        }
                        else
                        {
                            if (y == 3)
                            {
                                Console.WriteLine("Вы выбрали 2 комнаты без питания 900гр ");
                                price += 900;
                            }
                            else
                            {
                                Console.WriteLine("Вы выбрали 2 комнаты с питанием 1500гр");
                                price += 1500;
                            }
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали гостиницу Гуцулка\nВыберите кол-во комнат:\n1) 1 комнатабез питания 300гр\n2) 1 комната с питанием 500гр\n3) 2 комнаты без питания 450гр\n4) 2 2 комнаты спитанием 800гр ");
                    int z = Convert.ToInt32(Console.ReadLine());
                    if (z == 1)
                    {
                        Console.WriteLine("Вы выбрали 1 комнату без питанием 300гр");
                        price += 300;
                    }
                    else
                    {
                        if (z == 2)
                        {
                            Console.WriteLine("Вы выбрали 1 комнату c питанием 500гр");
                            price += 500;
                        }
                        else
                        {
                            if (z == 3)
                            {
                                Console.WriteLine("Вы выбрали 2 комнаты без питания 450гр");
                                price += 450;
                            }
                            else
                            {
                                Console.WriteLine("Вы выбрали 2 комнаты с питанием 800гр");
                                price += 800;
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Введен неверный номер ");
                    break;
            }
            Console.WriteLine($"К оплате {price}гр");
            Console.ReadKey();
        }
    }
};
