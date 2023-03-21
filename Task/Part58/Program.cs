using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization.Json;
using System.Xml.Linq;

namespace Part58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Price[] product = new Price[2];
            Price x = new Price();
            product = AddArray();
            Console.WriteLine("Сравнение элементов в массиве");
            if (x.CompareTo((object)product[0], (object)product[1]) == true)
            {
                Console.WriteLine("Товар 0 Больше Товара 1");
            }
            else
            {
                Console.WriteLine("Товар 0 Меньше Товара 1");
            }
            Console.WriteLine("Поиск товара ");
            Console.WriteLine("введите название товара, который желаете найти ");
            string text = Console.ReadLine();
            Console.WriteLine(ShowPrice(text, product));


            XmlSerializer formatter = new XmlSerializer(typeof(Price[]));
            using (FileStream fs = new FileStream("product.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, product);
                Console.WriteLine("Серелизация xml выполнена");
            }
            using (FileStream fs = new FileStream("product.xml", FileMode.OpenOrCreate))
            {
                Price[] newprice = formatter.Deserialize(fs) as Price[];

                if (newprice != null)
                {
                    foreach (Price p in newprice)
                    {
                        Console.WriteLine($"Name: {p.Name}\nShopName: {p.ShopName}\nPrice: {p.Coast}\nRare: {p.Rare}\n");
                    }
                }
            }
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<Price[]>(fs, product);
                Console.WriteLine("Серелизация json выполнена");
            }
            JsonSerialization<Price[]> json1 = new JsonSerialization<Price[]>("user.json");
            Console.WriteLine(json1.Deserialize());



            Console.ReadKey();
        }
        static Price[] AddArray()
        {
            Price[] newArr = new Price[2];
            for(int i = 0; i < newArr.Length;i++)
            {
                Console.WriteLine($"Введите название товара: {i}");
                string name = Console.ReadLine();
                Console.WriteLine("Введите название магазина");
                string shopName = Console.ReadLine();
                Console.WriteLine("Введите цену товара");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберите частоту редскость товара:\n0 - нормальная\n1 - редкая\n2 - эпическая");
                rarity q = (rarity)Convert.ToInt32(Console.ReadLine());
                Price a = new Price(name, shopName, price,q);
                newArr[i] = a;
            }
            return newArr;
        }
        static string ShowPrice(string text, Price[] x)
        {
            for(int i = 0; i < x.Length;i++)
            {
                if (x[i].Name == text)
                {
                    return x[i].ToString();
                }
            }
            return "Данный товар не найден";
        }
        public abstract class Serialization<Type>
        {
            public String Name { get; set; }
            public abstract void Serialize(Type data);
            public abstract Type Deserialize();
        }
        public class JsonSerialization<Type> : Serialization<Type>
        {
            DataContractJsonSerializer Serializer;
            public JsonSerialization(String name)
            {
                Serializer = new DataContractJsonSerializer(typeof(Type));
                if (name is null)
                {
                    throw new ArgumentNullException("name is null");
                }
                Name = name;
            }
            public override void Serialize(Type data)
            {
                using (FileStream fs = File.Create(Name))
                {
                    Serializer.WriteObject(fs, data);
                }
            }
            public override Type Deserialize()
            {
                Type data;
                using (FileStream fs = new FileStream(Name, FileMode.OpenOrCreate))
                {
                    data = (Type)Serializer.ReadObject(fs);
                }
                return data;
            }
        }
    }
}
