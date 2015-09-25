using System;

namespace Lab4
{
	public class Rectangle : Shape
    {
        private double _width, _height;

        public double Width
        {
            get { return _width; }
            set { if (value <= 0) _width = 1; else _width = value; }
        }

        public double Height
        {
            get { return _height; }
            set { if (value <= 0) _height = 1; else  _height = value; }
        }

        public Rectangle()
        {
            this.Width = 1.0;
            this.Height = 1.0;
        }
        public Rectangle(string color, double w, double h) : base(color)
        {
            this.Width = w;
            this.Height = h;
        }
        public Rectangle(Rectangle A) : base(A.Color)
        {
            this.Width = A.Width;
            this.Height = A.Height;
        }

        public override double getArea()
        {
            double area;
            area = this.Width * this.Height;
            return area;
        }
        public override double getPerimeter()
        {
            double perimeter;
            perimeter = (this.Width + this.Height) * 2.0 ;
            return perimeter;
        }

        public override string ToString()
        {
            string s;
            s = "[Rectangle: Width=" + this.Width + ", Height=" + this.Height + ",Area=" + this.getArea() + ",Color=\"" + base.Color + "\"]";
            return s;
        }
    }
}

