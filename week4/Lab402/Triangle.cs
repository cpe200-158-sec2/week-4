using System;

namespace Lab4
{
	public class Triangle : Shape
	{
        private double _width;
        private double _height;

        public override double getArea()
        {
            return Width * Height * 0.5;
        }
        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width) + (Height * Height));
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
        public Triangle ()
		{
            Height = 1.0;
            Width = 1.0;
            
        }

        public Triangle(string c,double w,double h):base(c)
        {
           
            Height = h;
            Width = w;
        }

        public Triangle(Rectangle r):base(r.Color)
        {
            Height = r.Height;
            Width = r.Width;
        }

        public override string ToString()
        {
            string st;
            st = "[Triangle: base=" + Width + " ,height=" + Height + " ,area=" + getArea() + " ,color= \"" + Color + "\"]";
            return st;
        }
    }
}

