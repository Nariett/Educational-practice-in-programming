using System;

namespace Part50
{
    enum Country { РБ, Россия, Казахстан }
    internal class money
    {
        int first;
        int second;
        DateTime data;
        Country country;

        public money(int first, int second, Country x)
        {
            this.first = first;
            this.second = second;
            this.data = DateTime.Now;
            this.country = x;
        }
        public int this[int x]
        {
            get
            {
                switch (x)
                {
                    case 0: return first;
                    case 1: return second;
                    default: throw new Exception("Unknown Property Name");
                }
            }
            set
            {
                switch (x)
                {
                    case 0:
                        {
                            first = value;
                            break;
                        }
                    case 1:
                        {
                            second = value;
                            break;
                        }
                    default: throw new Exception("Unknown Property Name");
                }
            }
        }
        public void price(int x)
        {
            int money = first * second;
            if (x - money <= 0)
            {
                Console.WriteLine("Денег хватит на покупку");
            }
            else
            {
                Console.WriteLine("Денег не хватит на покупку");
            }
        }
        public void tovar(int x)
        {
            int h = (first * second) / x;
            Console.WriteLine($"вы можете купить себе {h} товара");
        }
        public int f
        {
            get { return first; }
            set { first = value; }
        }
        public int s
        {
            get { return second; }
            set { second = value; }
        }
        public int sum
        {
            get { return first * second; }
        }
        public override string ToString()
        {
            return $"Номинал купюры {first}\nКол-во {second}\nВремя сдачи в банк {data:dd:MM:yyyy}\nБанк страны {country}";
        }
        public static money operator ++(money a)
        {
            a.first = a.first + 1;
            a.second = a.second + 1;
            return a;
        }
        public static money operator --(money a)
        {
            a.first = a.first - 1;
            a.second = a.second - 1;
            return a;
        }
        public static bool operator !(money a)
        {
            if (a.first != 0) return true;
            return false;
        }
        public static money operator +(money a, int value)
        {
            a.second += value;
            return a;
        }
    }
}
