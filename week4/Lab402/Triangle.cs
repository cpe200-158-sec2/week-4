using System;

namespace Lab4
{
    public class Triangle : Shape
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

        public Triangle()
        {
            _color = "gold"; //-
            Height = 1.0;
            Width = 1.0;
        }
        public Triangle(string c, double w, double h) //: base(c)
        {
            _color = c; //-
            Height = h;
            Width = w;
        }
        public Triangle(Triangle a) //: base(a.Color)
        {
            _color = a.Color; //-
            Height = a.Height;
            Width = a.Width;
        }

        //method
        public override double getArea()
        {
            return 0.5 * Width * Height;
        }
        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width) + (Height * Height));
        }
        public override string ToString()
        {
            return string.Format("[Triangle: base=" + Width + ", height=" + Height + ", area=" + getArea() + ", color=\"" + Color + "\"]");
        }



    }
}
