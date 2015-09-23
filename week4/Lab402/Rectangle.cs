using System;

namespace Lab402
{
	public class Rectangle : Shape
	{
        private double _width, _height;
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0.0)
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
                if( value > 0.0)
                {
                    _height = value;
                }
                else
                {
                    _height = 1.0;
                }
            }
        }
		public Rectangle ()
		{
            _height = 1.0;
            _width = 1.0;
		}
        public Rectangle (string c, double w, double h)
        {
            _color = c;
            _width = w;
            _height = h;
        }
        public Rectangle (Rectangle s)
        {
            _color = s.Color;
            _width = s.Width;
            _height = s.Height;
        }
        public override double getArea()
        {
            return _height * _width;
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]",Width,Height,getArea(),Color);
        }
        public override double getPerimeter()
        {
            return (2 * Height) + (2 * Width);
        }
    }
}

