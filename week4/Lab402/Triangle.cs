using System;

namespace Lab402
{
    public class Triangle : Shape
    {
        private double _width, _height;
        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    _width = 1.0;
                }
                else
                {
                    _width = value;
                }
            }
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                {
                    _height = 1.0;
                }
                else
                {
                    _height = value;
                }
            }
        }
        public Triangle()
        {
            Color = "gold";
            Width = 1.0;
            Height = 1.0;
        }
        public Triangle(string a, double b, double c) : base(a)
        {
            Width = b;
            Height = c;
        }
        public Triangle(Triangle A) : base(A.Color)
        {
            Width = A.Width;
            Height = A.Height;
        }
        public override double getArea()
        {
            return 0.5 * Height * Width;
        }

        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width) + (Height * Height));
        }

        public override string ToString()
        {
            return string.Format("[Triangle: width = {0}, height = {1}, area = {2}, color = \"{3}\"]", Width, Height, getArea(), Color);
        }
    }
}