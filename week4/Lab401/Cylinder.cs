using System;

namespace Lab4
{
    public class Cylinder : Circle
    {
        private double _height;
        public double Height
        {
            get { return _height; }
            set { if (value >= 0) { _height = value; } }
        }
        public Cylinder()
        {
            Height = 1.0;
        }
        public Cylinder(double r, double h)
        {
            Radius = r;
            Height = h;
        }
        public Cylinder(double x, double y, double r, double h)
        {
            base.setCircle(x, y, r);
            Height = h;
        }
        public Cylinder(Circle c)
        {
            base.setCircle(c.X, c.Y, c.Radius);
            Height = 1.0;
        }
        public Cylinder(Cylinder cl)
        {
            base.setCircle(cl.X, cl.Y, cl.Radius);
            Height = cl.Height;
        }
        public override double getArea()
        {
            return base.getArea() * 2 + 2 * Pi * Radius * Height;
        }
        public double getVolume()
        {
            return base.getArea() * Height;
        }
        public override string ToString()
        {
            string s = "[Cylinder: center(" + X + "," + Y + "), radius=" + Radius + ", height=" + Height + ", surface=" + getArea() + ", volume=" + getVolume() + "]";
            return s;
        }
    }
}