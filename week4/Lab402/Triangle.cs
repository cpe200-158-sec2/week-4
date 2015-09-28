using System;

namespace Lab4
{
	public class Triangle : Shape
	{
        //Private Properties
        private double _Width, _Height;

        //Public Properties
        public double Width
        {
            get { return _Width; }
            set
            {
                if (value > 0)
                    _Width = value;
                else
                    _Width = 1;
            }
        }
        public double Height
        {
            get { return _Height; }
            set
            {
                if (value > 0)
                    _Height = value;
                else
                    _Height = 1;
            }
        }

        //Constructors
        public Triangle ()
        {
            Width = 1;
            Height = 1;
        }
        public Triangle (string c, double w, double h) : base(c)
        {
            Width = w;
            Height = h;
        }
        public Triangle (Rectangle i) : base(i.Color)
        {
            Width = i.Width;
            Height = i.Height;
        }

        //Methods
        public override double getArea()
        {
            return 0.5 * Width * Height;
        }
        public override double getPerimeter()
        {
            return Width + Height + (Math.Sqrt(Math.Pow(Width/2, 2) + Math.Pow(Height, 2)));
        }
        public override string ToString()
        {
            return string.Format("[Triangle: base={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
        }
    }
}

