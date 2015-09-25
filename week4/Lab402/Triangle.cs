using System;

namespace Lab4
{
	public class Triangle : Shape
	{
        private double _w=1,_h=1;
        public double Width
        {
            get
            {
                return _w;
            }
            set
            {
                if (value > 0)
                    _w = value ;
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
        
		public Triangle (string col = "gold", double w=1, double h=1)
		{
            _w = w;
            _h = h;
            color = col;
		}
        public Triangle (Triangle t)
        {
            Width = t.Width;
            Height = t.Height;
            color = t.color;
        }
        public override double getArea()
        {
            return  Width * Height* 0.5;
        }
        public override string ToString()
        {
            return "[Triangle: base = " + Width + ", height = " + Height + ", area = " + getArea() + ", color = " + (char)34 + color + (char)34 + "]";
        }
        public override double getPerimeter()
        {
            double a = Height;
            double b = Width;

            return Width + Math.Sqrt(a*a + b*b) + Height;
        }
    }
}

