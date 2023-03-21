using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part59
{
    public abstract class Figura
    {
        public abstract string Show();
        public abstract double Square();
        public abstract double Length();
    }
    [Serializable]
    public class Circle : Figura
    {
        public int X1;
        public int X2;
        public int Y1;
        public int Y2;
        public int x1
        {
            get { return X1; }
            set { this.X1 = value; }
        }
        public int x2
        {
            get { return X2; }
            set { this.X2 = value; }
        }
        public int y1
        {
            get { return Y1; }
            set { this.Y1 = value; }
        }
        public int y2
        {
            get { return Y2; }
            set { this.Y2 = value; }
        }
        public Circle(int x1,int x2,int y1,int y2)
        {
            this.X1 = x1;
            this.X2 = x2;
            this.Y1 = y1;
            this.Y2 = y2;
        }
        public Circle() { }

        public override string Show() 
        {
            return $"Диаметр: {Math.Sqrt(Math.Pow(Y2 - Y1, 2) + Math.Pow(X2 - X1, 2))}\nРадиус: {Math.Sqrt(Math.Pow(Y2-Y1,2)+Math.Pow(X2-X1,2))*2}";
        }
        public override double Square()
        { 
            return 3.14 * Math.Pow(Math.Sqrt(Math.Pow(Y2 - Y1, 2) + Math.Pow(X2 - X1, 2)), 2);
        }
        public override double Length()
        {
            return 2* 3.14 * Math.Pow(Math.Sqrt(Math.Pow(Y2 - Y1, 2) + Math.Pow(X2 - X1, 2)), 2);
        }
    }
    public class Suqare : Circle
    {
        public int Z1;
        public int Z2;
        public int z1
        {
            get { return Z1; }
            set { this.Z1 = value; }
        }
        public int z2
        {
            get { return Z2; }
            set { this.Z2 = value; }
        }
        public Suqare(int x1, int x2, int y1, int y2, int z1,int z2) : base(x1,x2,y1,y2)
        {
            this.Z1 = z1;
            this.Z2 = z2;
        }
        public Suqare() { }
        public override string Show()
        {
            return $"Сторона AB: {Math.Sqrt(Math.Pow(Y2 - Y1, 2) + Math.Pow(X2 - X1, 2))}\nСторно BC: {Math.Sqrt(Math.Pow(Z2 - Z1, 2) + Math.Pow(X2 - X1, 2))}";
        }
        public override double Square()
        {
            return Math.Pow(Math.Sqrt(Math.Pow(Y2 - Y1, 2) + Math.Pow(X2 - X1, 2)), 2) * Math.Sqrt(Math.Pow(Z2 - Z1, 2) + Math.Pow(X2 - X1, 2));
        }
        public override double Length()
        {
            return Math.Pow(Math.Sqrt(Math.Pow(Y2 - Y1, 2) + Math.Pow(X2 - X1, 2)), 2) *2 + Math.Sqrt(Math.Pow(Z2 - Z1, 2) + Math.Pow(X2 - X1, 2))* 2;
        }

    }
}
