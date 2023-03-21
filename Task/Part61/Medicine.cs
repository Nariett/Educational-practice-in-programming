using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part61
{
    internal class Medicine
    {
        public string name { get; set; }
        public double price { get; set; }
        public double dosage { get; set; }
        public Color color { get; set; }
        public Consistency consistency { get; set; }
        public Testimony testimony { get; set; }
        public Medicine(string name, double price, double dosage, Color color, Consistency consistency, Testimony testimony)
        {
            this.name = name;
            this.price = price;
            this.dosage = dosage;
            this.color = color;
            this.consistency = consistency;
            this.testimony = testimony;
        }
        public Medicine() { }

    }
}
