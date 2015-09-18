using System;

namespace Lab4
{
	public class Cylinder : Circle //inherit frome circle class
	{
        //member
        public Circle Base = new Circle();
        private double _height;
        //properties
        public double Height
        {
            get
            {
                return _height;
            }

            set
            {   if( value >= 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1.0;
                }
                
            }
        }

        //constructor
        public Cylinder ()
		{
            Height = 1.0;
		}
        public Cylinder (double r, double h)
        {
            Base.Radius = r;
            Height = h;    
        }
        public Cylinder (double x,double y, double r ,double h)
        {
            Base.Center.X = x;
            Base.Center.Y = y;
            Base.Radius = r;
            Height = h;
        }
        public Cylinder (Circle a)
        {
            Base.Center.X = a.Center.X;
            Base.Center.Y = a.Center.Y;
            Base.Radius = a.Radius;
            Height = 1.0;
            
        }
        public Cylinder (Cylinder b)
        {
            Base.Center.X = b.Base.Center.X;
            Base.Center.Y = b.Base.Center.Y;
            Base.Radius = b.Base.Radius;
            Height = b.Height;
        }
        //method
        public override double getArea ()
        {
            double area = (2 * Math.PI * Base.Radius*Base.Radius) + (2 * Math.PI * Base.Radius* Height);
            return area;
        }
        public double getVolume()
        {
            double volume = Math.PI * Base.Radius * Base.Radius * Height;
            return volume;
        }
        public override string ToString()
        {
            string output = ("[Cylinder: center("+ Base.Center.X +","+ Base.Center.Y + "), radius="+ Base.Radius + ", height="+ Height + ", surface="+ getArea() + ", volume="+ getVolume());
            return output;
        }

    }
}

