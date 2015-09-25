using System;

namespace Lab402
{
    public class Rectangle : Shape
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

        public Rectangle()
        {
            Color = "gold";
            Width = 1.0;
            Height = 1.0;
        }
        public Rectangle(string a, double b, double c) : base(a)
        {
            Width = b;
            Height = c;
        }
        public Rectangle(Rectangle A) : base(A.Color)
        {
            Color = A.Color;
            Width = A.Width;
            Height = A.Height;
        }
        public override double getArea()
        {
            return Height * Width;
        }

        public override double getPerimeter()
        {
            return 2 * (Height + Width);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width = {0}, height = {1}, area = {2}, color = \"{3}\"]", Width, Height, getArea(), Color);
        }
    }
}