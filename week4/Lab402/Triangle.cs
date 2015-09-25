using System;

namespace Lab4
{
    public class Triangle : Shape
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

        public Triangle()
        {
            _c = "gold";
            Width = 1.0;
            Height = 1.0;
        }
        public Triangle(string c, double w, double h)
        {
            _c = c;
            Width = w;
            Height = h;
        }
        public Triangle(Triangle a)
        {
            _c = a.Color;
            Width = a.Width;
            Height = a.Height;
        }

        public override double getArea()
        {
            return 0.5 * Width * Height;
        }
        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width) + (Height * Height));
        }
        public override string ToString()
        {
            return string.Format("[Triangle: base=" + Width + ", height=" + Height + ", area=" + getArea() + ", color=\"" + Color + "\"]");
        }
    }
}

