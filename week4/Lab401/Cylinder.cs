using System;

namespace Lab401
{
	public class Cylinder:Circle 
	{
        
        private double _Height;
		
        public double Height
        {
            get { return _Height; }
            set
            {
                if (value >=0)
                {
                    _Height = value;
                }
                else { _Height = 1.0; }
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
        public Cylinder(double a,double b,double c,double d)
        {
            setCircle(a, b, c);
            Height = d;
        }
        public Cylinder(Circle a)
        {
            x = a.x;
            y = a.y;
            Radius = a.Radius;
            Height = 1;
        }
        public Cylinder(Cylinder a)
        {
            x = a.x;
            y = a.y;
            Radius = a.Radius;
            Height = a.Height;
        }
        public override double getArea()
        {
            return (2.0 * base.getArea()) + (2.0 * Math.PI * Radius * Height);
        }
        public double getVolume()
        {
            return  base.getArea()* Height;
        }

        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", x,y, Radius, Height, getArea(), getVolume());

        }

    }
}

