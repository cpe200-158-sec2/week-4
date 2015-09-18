using System;

namespace Lab4
{
	public class Circle
	{
        private double Radius;

        public double radius
        {
            get { return Radius; }
            set { if (value >= 0) Radius = value;
                else Radius = 1;
            }                       
        }

        public Point C =new Point();

        public Circle ()
		{
            setCircle(0, 0, 1);     
		}

        public Circle(Circle a)
        {
            setCircle(a.C.x, a.C.y, a.radius);
        }

        public Circle(double r)
        {
            setCircle(0, 0, r);
        }

        public Circle(double a , double b , double r)
        {
            setCircle(a, b, r);       
        }

        public virtual void setCircle(double a , double b , double r)
        {
            C.x = a;
            C.y = b;
            radius = r;
        }

        public virtual double getArea()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return string.Format("[Circle: center{0}, radius={1}, area={2}]", C, radius, getArea());
        }



    }
}

