using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Part58
{
    public enum rarity { common, rare, epic }
    public interface IComparable
    {
        bool CompareTo(object x,object y);
    }
    [Serializable]
    public class Price : IComparable
    {
        public string name;
        public string shopName;
        public double price;
        public rarity rare;
        public Price(string name, string shopName, double price,rarity rare)
        {
            this.name = name;
            this.shopName = shopName;
            this.price = price;
            this.rare = rare;
        }
        public Price(){ }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string ShopName
        {
            get { return this.shopName; }
            set { this.shopName = value; }
        }
        public double Coast
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public double GetPrice
        {
            get
            {
                return this.price;
            }
        }
        public rarity Rare
        {
            get { return this.rare; }
            set { this.rare = value; }
        }
        public bool CompareTo(object x,object y)
        {
            Price one = (Price)x;
            Price two = (Price)y;
            if (one.GetPrice > two.GetPrice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"Имя: {this.name}\nНазвание магазина: {this.shopName}\nЦена: {this.price}\nРедкость {this.rare}";
        }
    }
}
