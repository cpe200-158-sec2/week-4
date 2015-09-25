using System;

namespace Lab4
{
	public class Triangle : Shape
    {
        private double _width, _height;

        public double Width
        {
            get { return _width; }
            set{ if (value <= 0)  _width = 1; else _width = value;  }
        }
        public double Height
        {
            get { return _height; }
            set { if (value <= 0) _height = 0; else _height = value; }
        }

        public Triangle()
        {
            this.Width = 1.0;
            this.Height = 1.0;
        }
        public Triangle(string color, double w, double h) : base(color)
        {
            this.Width = w;
            this.Height = h;
        }
        public Triangle(Rectangle R) : base(R.Color)
        {
            this.Width = R.Width;
            this.Height = R.Height;
        }

        public override double getArea()
        {
            double area;
            area = 0.5 * this.Width * this.Height;
            return area;
        }
        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt(Width * Width + Height * Height);
        }

        public override string ToString()
        {
            string s;
            s = "[Triangle: Width=" + this.Width + ", Height=" + this.Height + ",Area=" + this.getArea() + ",Color=\"" + base.Color + "\"]";
            return s;
        }
    }
}

