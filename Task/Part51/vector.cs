using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Part51
{
    internal class vector
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        public vector() { }
        public vector(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public vector(int x, int y)
        {
            this.x1 = x;
            this.y1 = y;
        }
        public double Length()
        {
            return 2 * Math.Sqrt(Math.Pow(this.x2 - this.x1, 2) + Math.Pow(this.y2 - this.y1, 2));
        }
        public override string ToString()
        {
            return $"Координаты точек:\nx1 = {this.x1}\ny1 = {this.y1}\nx2 = {this.x2}\ny2 = {this.y2}";
        }
        public int X1
        {
            get { return this.x1; }
        }
        public int Y1
        {
            get { return this.y1; }
        }
        public int X2
        {
            get { return this.x2; }
        }
        public int Y2
        {
            get { return this.y2; }
        }

    }
}
