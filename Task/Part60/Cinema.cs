using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part60
{
    internal class Cinema
    {
        private string name;
        private string street;
        private int hall;
        private Film[] film;
        public Cinema(string name, string street, int hall, Film[] film)
        {
            this.name = name;
            this.street = street;
            this.hall = hall;
            this.film = film;
        }
        public string Name
        {
            get { return name;}
            set { this.name = value;}
        }
        public int Hall
        {
            get { return hall; }
            set { this.hall = value; }
        }
        public Film[] Film
        {
            get { return film; }
            set { this.film = value; }
        }
        public string Street
        {
            get { return street;}
            set { this.street = value;}
        }
        public Cinema() { }
        public override string ToString()
        {
            return $"Название кинотеатра {name}, Расположение кинотеатра: {street}, Кол-во залов: {hall}";
        }
    }
}
