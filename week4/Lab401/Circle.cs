using System;

namespace Lab4
{
	public class Circle : Point
	{
        private static double _pi = 3.14159265358979;
        public static double Pi
        {
            get { return _pi; }
        }
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set { if(value>=0) { _radius = value; } }
        }
		public Circle ()
		{
            Radius = 1.0;
		}
        public Circle (double r)
        {
            Radius = r;
        }
        public Circle (double x, double y, double r)
        {
            setCircle(x, y, r);
        }
        public Circle (Circle c)
        {
            this.X = c.X;
            this.Y = c.Y;
            this.Radius = c.Radius;
        }
        public void setCircle(double x, double y, double r)
        {
            Radius = r;
            X = x;
            Y = y;
        }
        public virtual double getArea()
        {
            return Radius*Radius*Pi;
        }
        public override string ToString()
        {
            string s = "[Circle: center(" + X + "," + Y + "), radius=" + Radius + ", area=" + getArea() + "]";
            return s;
        }

    }
}

