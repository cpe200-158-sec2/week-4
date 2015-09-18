using System;

namespace Lab4
{
	public class Cylinder:Circle
	{
        private double height;
        public double Height
        {
            get { return height; }
            set
            {
                if (height >= 0)
                {
                    height = value;
                }
                else
                {
                    height = 1;
                }
            }
        }
        public Cylinder()
        {
            height = 0;
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
            
            this.X = c.X;
            this.Y = c.Y;
            this.Radius = c.Radius;
        }
        public Cylinder(Cylinder c)
        {
            this.X = c.X;
            this.Y = c.Y;
            this.Radius = c.Radius;
            this.Height = c.Height;
        }
        public override string ToString()
        {
            string s = "[Cylinder: center(" + X + "," + Y + "), radius=" + Radius + ", height=" + Height + ", surface=" + getArea() + ", volume=" + getVolume() + "]";
            return s;
        }
    public override double getArea()
        {
            return (2 * Math.PI * Radius* Height) + (2 * base.getArea());
        }
        public double getVolume()
        {
            return ( Height* base.getArea());
        } 
	}
}

