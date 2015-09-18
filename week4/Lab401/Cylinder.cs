using System;

namespace Lab4
{
    public class Cylinder:Circle 
    {
        private double  _height= 1.0;
        public double Height
        {
            set { if (value >= 0) _height = value; }
            get { return _height; }
        }
        public Cylinder()
        {
            
        }
        public Cylinder(double a, double b)
        {
            Radius = a;
            Height = b;
        }
        public Cylinder(double a, double b, double c, double d)
        {
            X = a;
            Y = b;
            Radius = c;
            Height = d;
        }
        public Cylinder(Circle a)
        {
            X = a.X;
            Y = a.Y;
            Radius = a.Radius;
        }
        public Cylinder(Cylinder a)
        {
            X = a.X;
            Y = a.Y;
            Radius = a.Radius;
            Height = a.Height;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center({0}, {1}), radius={2}, height={3}, surface={4}, volume={5}]", X, Y,Radius ,Height ,getArea (),getVolume ()); 
    }
        public override double getArea()
        {
            return (2 * Math.PI * Radius * Height) + (2 * base.getArea());
        }
        public double getVolume()
        {
            return ( Height* base.getArea());
        }
    }
    
}

