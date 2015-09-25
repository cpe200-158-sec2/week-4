using System;

namespace Lab4
{
    public class Rectangle : Shape
    {
        private double _w;
        private double _h;

        public double Width
        {
            get { return _w; }
            set
            {
                if (value > 0)
                {
                    _w = value;
                }
                else
                {
                    _w = 1.0;
                }
            }
        }
        public double Height
        {
            get { return _h; }
            set
            {
                if (value > 0)
                {
                    _h = value;
                }
                else
                {
                    _h = 1.0;
                }
            }
        }

        public Rectangle()
        {
            Color = "gold";
            Width = 1.0;
            Height = 1.0;
        }
        public Rectangle(string c, double w, double h)
        {
            Color = c;
            Width = w;
            Height = h;
        }
        public Rectangle(Rectangle a)
        {
            Color = a.Color;
            Width = a.Width;
            Height = a.Height;
        }

        public override double getArea()
        {
            return Width * Height;
        }
        public override double getPerimeter()
        {
            return (Width + Height) * 2.0;
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width=" + Width + ", height=" + Height + ", area=" + getArea() + ", color=\"" + Color + "\"]");
        }
    }
}

