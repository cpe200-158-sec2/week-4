using System;

namespace Lab4
{
	public class Triangle : Shape
	{
        private double _width = 1.0, _height = 1.0;
        public double Height
        {
            get { return _height; }
            set { if (value > 0) _height = value; else _height = 1; }
        }
        public double Width
        {
            get { return _width; }
            set { if (value > 0) _width = value; else _width = 1; }
        }
        public Triangle (){}
        public Triangle(string c, double w, double h)
        {
            _color = c;
            Width = w;
            Height = h;
        }
        public Triangle(Triangle r)
        {
            _color = r.Color;
            Width = r.Width;
            Height = r.Height;
        }
        public override double getArea()
        {
            return Width * Height * 0.5;
        }
        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt(Width * Width + Height * Height);
        }
        public override string ToString()
        {
            return String.Format("[Triangle: base={0}, height={1}, area={2}, color={3}]", Width, Height, getArea(), Color);
        }

    }
}

