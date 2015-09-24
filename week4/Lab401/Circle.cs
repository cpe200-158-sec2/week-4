using System;

namespace Lab4
{
	public class Circle:Point
	{

        private double _radius;
        

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value < 0)
                {
                    _radius = 1.0;
                }
                else
                    _radius = value;
            }
        }

        public Circle()
        {
            setCircle(0, 0, 1);
        }

        public Circle(double r)
        {
            setCircle(0, 0, r);
        }

        public Circle(double x,double y,double r)
        {
            setCircle(x, y, r);

        }

        public Circle(Circle c)
        {
            X = c.X;
            Y = c.Y;
            Radius = c._radius;
        }

        public void setCircle(double x,double y,double r)
        {
            X = x;
            Y = y;
            Radius = r;
        
        }

        public virtual double getArea()
        {
            double area;
            area = Math.PI * Radius * Radius;
            return area;
        }

        public override string ToString()
        {
            string st;
            st = "[Circle: center(" + X + ", " + Y + "), radius = " + Radius + ", area = " + getArea() + "]";
            return st;
            
        }
    }
}

