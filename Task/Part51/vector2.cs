using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part51
{
    internal class vector2:vector
    {
        private int a;
        private int b;
        public vector2(int x1,int y1,int x2,int y2,int a, int b):base(x1+a,y1,x2,y2-b)
        {
            this.a = a;
            this.b = b;
        }
        public double X21
        {
            get { return X1; }
        }
        public double Y21
        {
            get { return Y1; }
        }
        public override string ToString()
        {
            return $"Координаты точек:\nx1 = {this.X1}\ny1 = {this.Y1}\nx2 = {this.X2}\ny2 = {this.Y2}";
        }
        public double Per()
        {
            return Math.Sqrt(Math.Pow(this.X1 - this.Y21, 2) + Math.Pow(this.Y1 - this.Y21, 2));
        }
    }
}
