using System;

namespace Lab4
{
	public class Rectangle : Shape
	{
        private double _width;
        private double _height;

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

        public override double getArea()
        {
            return Height * Width;
        }

        public override double getPerimeter()
        {
            return 2 * (Height + Width);
        }
        public Rectangle ()
		{
            Height = 1.0;
            Width = 1.0;
            
        }

        public Rectangle(string c,double w,double h):base(c)
        {
          
            Height = h;
            Width = w;
        }

        public Rectangle(Rectangle r):base(r.Color)
        {
            
            Height = r.Height;
            Width = r.Width;
        }

        public override string ToString()
        {
            string st;
            st = "[Rectangle: width=" + Width + " ,height=" + Height + " ,area=" + getArea() + " ,color= \"" + Color + "\"]";
            return st; 
        }
    }
}

