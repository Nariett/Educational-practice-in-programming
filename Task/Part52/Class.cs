using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Part52
{
    abstract class Client
    {
        public abstract string Name { get; }
        public abstract DateTime Data { get; }
        public abstract double Size { get; }
        public abstract double Percent { get; }
        public abstract Depositor[] CompareTo(Depositor[] Bank);
        public void show()
        {
            Console.WriteLine($"Клиент {Name}\nДата регистрации вклада {Data:d}\nРазмер вклада {Size}\nПроцентная ставка {Percent}");
        }
    }
    class Depositor : Client
    {
        private string name;
        private DateTime data;
        private double size;
        private double percent;
        public int this[int index]
        {
            get 
            {
                switch (index)
                {
                    case 0: return data.Day;
                    case 1: return data.Month;
                    case 2: return data.Year;
                    default: throw new Exception("Unknown Property Name");
                }
            }
        }
        public override string Name
        {
            get
            {
                return name;
            }
        }
        public override DateTime Data
        {
            get
            {
                return data;
            }
        }
        public override double Size
        {
            get
            {
                return size;
            }
        }
        public override double Percent
        {
            get
            {
                return percent;
            }
        }
        public Depositor(string name, DateTime data, double size, double percent)
        {
            this.name = name;
            this.data = data;
            this.percent = percent;
            this.size = size;
        }
        public Depositor[] Enter(int size)
        {
            Depositor[] Bank = new Depositor[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Введите имя");
                string name = Console.ReadLine();
                Console.WriteLine("Введите день");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите месяц");
                int mouth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите размер вклада");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите размер процентного вклада");
                double percent = Convert.ToDouble(Console.ReadLine());
                Depositor x = new Depositor(name, new DateTime(year, mouth, day), price, percent);
                Bank[i] = x;
            }
            return Bank;
        }
        public override Depositor[] CompareTo(Depositor[] Bank)
        {
            for (int i = 0; i < Bank.Length - 1; i++)
            {
                for (int j = 0; j < Bank.Length - i - 1; j++)
                {
                    if (Bank[j][2] > Bank[j+1][2])
                    {
                        // меняем элементы местами
                        Depositor temp = Bank[j];
                        Bank[j] = Bank[j + 1];
                        Bank[j + 1] = temp;
                    }
                }
            }
            return Bank;
        }
        class Creditor:Client
        {
            private string name;
            private DateTime data;
            private double size;
            private double percent;
            private double ostatok;
            public Creditor(string name, DateTime data, double size, double percent,double ostatok)
            {
                this.name = name;
                this.data = data;
                this.percent = percent;
                this.size = size;
                this.ostatok = ostatok;
            }
            public override string Name
            {
                get
                {
                    return name;
                }
            }
            public override DateTime Data
            {
                get
                {
                    return data;
                }
            }
            public override double Size
            {
                get
                {
                    return size;
                }
            }
            public override double Percent
            {
                get
                {
                    return percent;
                }
            }
            public override Depositor[] CompareTo(Depositor[] Bank)
            {
                /*Depositor[] Bank = new Depositor[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Введите имя");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите день");
                    int day = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите месяц");
                    int mouth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите год");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите размер вклада");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите размер процентного вклада");
                    double percent = Convert.ToDouble(Console.ReadLine());
                    Depositor x = new Depositor(name, new DateTime(year, mouth, day), price, percent);
                    Bank[i] = x;
                }*/
                return Bank;
            }

        }
    }
}
