using System;

namespace Lab4
{
	public class Rectangle : Shape
	{
        private double _Width;
        private double _Height;

        public double Width
        {
            get
            {
                return _Width;
            }

            set
            {
                if(value > 0)
                {
                    _Width = value;
                }
                else
                {
                    _Width = 1;
                }              
            }
        }
        public double Height
        {
            get
            {
                return _Height;
            }

            set
            {
                if (value > 0)
                {
                    _Height = value;
                }
                else
                {
                    _Height = 1;
                }
            }
        }

        public Rectangle ()
		{
            Width = 1;
            Height = 1;
		}

        public Rectangle (string colour , double w , double h)
        {
            Color = colour;
            Width = w;
            Height = h;
        }

        public Rectangle (Rectangle a)
        {
            Color = a.Color;
            Width = a.Width;
            Height = a.Height;
        }

        public override double getArea()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "[Rectangle: width=" + Width + ", height=" + Height + ", area=" + getArea() + ", color=" + Color + "]";
        }

        public override double getPerimeter()
        {
            return Width * 2 + Height * 2;
        }
    }
}

