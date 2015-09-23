using System;

namespace Lab4
{
    public class Triangle : Shape
    {
        private double _width = 1.0;
        private double _height = 1.0;
        public double Width
        {
            set
            {
                if (value > 0.0) _width = value;
                else _width = 1.0;
            }
            get { return _width; }
        }
        public double Height
        {
            set
            {
                if (value > 0.0) _height = value;
                else _height = 1.0;
            }
            get { return _height; }
        }
        public Triangle() : base("gold")
        {
            Width = 1.0;
            Height = 1.0;
        }
        public Triangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        public Triangle(Rectangle a) : base(a.Color)
        {
            Width = a.Width;
            Height = a.Height;
        }
        public override double getArea()
        {
            return Height * Width * 0.5;
        }
        public override double getPerimeter()
        {
            return Width + Height + (Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2)));
        }
        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
        }
    }
}

