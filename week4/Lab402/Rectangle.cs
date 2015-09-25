using System;

namespace Lab4
{
    public class Rectangle : Shape
    {
        //member
        private double _height;
        private double _width;

        //properties
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1.0;
                }
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    _width = 1.0;
                }

            }
        }

        //constructor
        public Rectangle()
        {
            _color = "gold"; //-
            Height = 1.0;
            Width = 1.0;
        }
        public Rectangle(string c, double w, double h) // : base(c)
        {
            _color = c; // -
            Height = h;
            Width = w;

        }
        public Rectangle(Rectangle a) // : base(a.Color)
        {
            _color = a.Color; // -
            Height = a.Height;
            Width = a.Width;
        }
        //method
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
