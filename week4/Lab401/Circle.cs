using System;

namespace Lab4
{
	public class Circle : Point
	{
		private static double pi =3.14159265358979;
        private double radius;
        public double Pi
        {
            get { return pi; }
        }
        public double Radius
        {
            get { return radius; }
            set
            {
                if (radius >= 0)
                {
                    radius = value;
                }
                else {
                    radius = 1;
                }
            }
        }
        public Circle()
        {
            Radius = 0;
        }
        public Circle (double r)
        {
            Radius = r;
        }
        public Circle (double x,double y,double r)
        {
            setCircle(x, y, r);
        }
        public Circle(Circle c)
        {
            this.X = c.X;
            this.Y = c.Y;
            this.Radius = c.Radius;
        }
        public void setCircle(double x, double y, double z)
        {
            X = x;
            Y = y;
            Radius = z;
        }
        public virtual double getArea()
        {
           return Radius* Radius*Pi;
       }
        public override string ToString()
        {
            string s = "[Circle: center(" + X + "," + Y + "), radius=" + Radius + ", area=" + getArea() + "]";
            return s;
        }
	}
}

