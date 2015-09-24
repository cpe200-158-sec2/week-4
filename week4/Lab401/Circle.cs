using System;

namespace Lab401
{
    public class Circle : Point
    {


        private static double _pi = 3.14159265358979;
        private double _radius;


        public static double Pi
        {
            get { return _pi; }
        }

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value >= 0)
                {
                    _radius = value;
                }
            }

        }
        public Circle()
        {
            Radius = 1.0;
        }
        public Circle(double r)
        {
            Radius = r;
        }
        public Circle(double x, double y, double r)
        {
            setCircle(x, y, r);
        }
        public Circle(Circle c)
        {
            this.A = c.A;
            this.B = c.B;
            Radius = c.Radius;
        }
        public void setCircle(double x, double y, double r)
        {
            Radius = r;
            double A = x;
            double B = y;

        }
        public virtual double getArea()
        {
            return Radius * Radius * Pi;
        }
        public override string ToString()
        {
            string tt = "[Circle : center" + A + "," + B + "radius=" + Radius + ", area=" + getArea() + "]";
            return tt;
        }
    }
}

