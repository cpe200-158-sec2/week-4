using System;

namespace Lab4
{
	public class Circle : Point
    {
		private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value >= 0) radius = value;
                else radius = 1.0;
            }
        }

        public Circle()
        {
            setCircle(0, 0, 1.0);
        }
        public Circle(double r)
        {
            setCircle(0, 0, r);
        }
        public Circle(double x, double y, double r)
        {
            setCircle(x, y, r);
        }
        public Circle(Circle a)
        {
            this.X = a.X;
            this.Y = a.Y;
            this.Radius = a.Radius;
        }
        public void setCircle(double x, double y, double r)
        {
            Radius = r;
            X = x;
            Y = y;
        }

        public virtual double getArea()
        {
            return Radius * Radius * Math.PI;
        }

        public override string ToString()
        {
            string answer = "[Circle: center(" + X + "," + Y + "), radius=" + Radius + ", area=" + getArea() + "]";
            return answer;
        }

    }
}


