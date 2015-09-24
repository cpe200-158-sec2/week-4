using System;

namespace Lab4
{
	public class Triangle:Shape
	{
        private double _Width, _Height;

        public double Width
        {
            get { return _Width; }
            set
            {
                if (value < 0) { _Width = 1.0; }
                else { _Width = value; }
            }
        }
        public double Height
        {
            get { return _Height; }
            set
            {
                if (value < 0) { _Height = 1.0; }
                else { _Height = value; }
            }
        }
        public Triangle()
        {
            Height = 1.0;
            Width = 1.0;
        }
        public Triangle(string s, double w, double h):base(s)
        {
            Height = h;
            Width = w;
        }
        public Triangle(Triangle a):base(a.Color)
        {
            Height = a.Height;
            Width = a.Width;
        }
        public override double getArea()
        {
            return Height * Width*0.5;
        }
        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width) + (Height * Height));
        }
        
        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
        }
    }
}

