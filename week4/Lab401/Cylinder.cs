using System;

namespace Lab4
{
    public class Cylinder : Circle
    {
        private double _height;
        public Circle _surface = new Circle();
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public Cylinder()
        {
            Height = 1.0;
        }

        public Cylinder(double r, double h)
        {
            _surface.Radius = r;
            Height = h;
        }

        public Cylinder(double x, double y, double r, double h)
        {
            _surface._center.X = x;
            _surface._center.Y = y;
            _surface.Radius = r;
            Height = h;
        }

        public Cylinder(Circle a)
        {
            _surface._center.X = a._center.X;
            _surface._center.Y = a._center.Y;
            _surface.Radius = a.Radius;
            Height = 1.0;
        }

        public double getArea()
        {
            double area = (2 * Math.PI * _surface.Radius * _surface.Radius) + (2 * Math.PI * _surface.Radius * Height);
            return area;
        }

        public double getVolume()
        {
            double volume = Math.PI * _surface.Radius * _surface.Radius * Height;
            return volume;
        }

        public override string ToString()
        {
            return string.Format("[Cylinder: center{0}, radius={1}, height={2}, surface={3}, volume={4}]", _surface._center, _surface.Radius, Height, getArea(), getVolume());
        }

        public Cylinder(Cylinder a1)
        {
            _surface._center.X = a1._surface._center.X;
            _surface._center.Y = a1._surface._center.Y;
            _surface.Radius = a1._surface.Radius;
            Height = a1.Height;
        }
    }
}

