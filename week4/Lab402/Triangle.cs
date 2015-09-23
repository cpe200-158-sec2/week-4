using System;

namespace Lab402
{
	public class Triangle : Shape
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
                if ( value > 0.0)
                {
                    _width = value;
                }
                else
                {
                    _width = 1;
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
		public Triangle ()
		{
            _height = 1.0;
            _width = 1.0;
		}
        public Triangle (string c,double w,double h)
        {
            _color = c;
            _width = w;
            _height = h;
        }
        public Triangle (Triangle t)
        {
            _color = t.Color;
            _height = t.Height;
            _width = t.Width;
        }
        public override double getArea()
        {
            return 0.5 * _width * _height;
        }
        public override double getPerimeter()
        {
            return _height + _width + Math.Sqrt(Math.Pow(_height, 2) + Math.Pow(_width, 2));
        }
        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"]",Width,Height,getArea(),Color);
        }
    }
}

