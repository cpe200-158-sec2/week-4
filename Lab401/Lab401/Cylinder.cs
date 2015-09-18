using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _Height = 1.0 ;
        public double Height
        {
            get
            {
                return _Height;
            }

            set
            {
                _Height = value;
            }
        }

        public Cylinder ()
		{
            setCircle(0, 0, 1);
            Height = 1;
		}

        public Cylinder(double a,double b)
        {
            setCircle(0, 0, a);
            Height = b;
        }

        public Cylinder(double a, double b, double c, double d)
        {
            setCircle(a, b, c);
            Height = d;
        }

        public Cylinder(Circle a)
        {
            setCircle(a.Center.X, a.Center.Y, a.Radius);
        }

        public Cylinder(Cylinder a)
        {
            setCircle(a.Center.X, a.Center.Y, a.Radius);
            Height = a.Height;
        }
        

        public double getArea()
        {
            return (2 * 3.14159265358979 * Radius * Height) + (2 * 3.14159265358979 * Radius * Radius);
        }

        public double getVolume()
        {
            return 3.14159265358979 * Radius * Radius * Height;
        }

        public override string ToString()
        {
            return "[Cylinder: center("+Center.X+","+Center.Y+"), radius="+Radius+", height="+Height+", surface="+getArea()+", volume="+getVolume()+"]";
        }

    }
}

