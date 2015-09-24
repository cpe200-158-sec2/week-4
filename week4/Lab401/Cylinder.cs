using System;

namespace Lab4
{
	public class Cylinder:Circle
	{
        private double _height;
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                {
                    _height = 1;
                }
                else
                    _height = value;
            }
        }


		public Cylinder ()
		{
            setCircle(0, 0, 1);
            Height = 1;
		}

        public Cylinder(double r,double h)
        {

            Radius = r;
            Height = h;
        }

        public Cylinder(double x,double y,double r,double h)
        {
            setCircle(x, y, r);
            Height = h;
        }

        public Cylinder(Circle c)
        {
            X = c.X;
            Y = c.Y;
            Radius = c.Radius;
            Height = 1;
        }

        public Cylinder(Cylinder c)
        {
            X = c.X;
            Y = c.Y;
            Radius = c.Radius;
            Height = c.Height;
        }

        public override double getArea()
        {
            double area;
            area = (2 * Math.PI  * Radius * Height) + (2 * base.getArea());
            return area;
        }

        public double getVolume()
        {
            double volume;
            volume= base.getArea() * Height;
            return volume;

        }
        public override string ToString()
        {
            string st;
            st = "[Cylender: center(" + X + ", " + Y + "), radius=" + Radius + ", height=" + Height + ", surface=" + getArea() + ", volume=" + getVolume() + "]";
            return st;
            

    }
    }
}

