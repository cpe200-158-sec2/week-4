using System;

namespace Lab4
{
	public class Rectangle : Shape
	{
        private double _w = 1, _h = 1;
        public double Width
        {
            get
            {
                return _w;
            }
            set
            {
                if (value > 0)
                    _w = value;
                else _w = 1;
            }
        }
        public double Height
        {
            get
            {
                return _h;
            }
            set
            {
                if (value > 0)
                    _h = value;
                else _h = 1;
            }
        }
		public Rectangle (string col = "gold", double width = 1, double height = 1)
		{
            _w = width;
            _h = height;
            color = col;
		}
        public Rectangle (Rectangle r)
        {
            _w = r.Width;
            _h = r.Height;
            color = r.color;
        }
        override public double getArea()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return "[Rectangle: width = "+Width+", height = "+Height+", area = "+getArea()+", color = "+(char)34+color+(char)34+"]";
        }
        public override double getPerimeter()
        {
            return Width * 2 + Height * 2;
        }
    }
}

