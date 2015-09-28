using System;

namespace Lab4
{
	public class Rectangle : Shape
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
        public Rectangle ()
		{
            Width = 1;
            Height = 1;
		}
        public Rectangle (string c, double w, double h) : base(c)
        {
            Width = w;
            Height = h;
        }
        public Rectangle (Rectangle i) : base(i.Color)
        {
            Width = i.Width;
            Height = i.Height;
        }

        //Methods
        public override double getArea()
        {
            return Width * Height;
        }
        public override double getPerimeter()
        {
            return (2 * Width) + (2 * Height);
        }
        public override string ToString()
        {
            return string.Format("[Rectangle: width={0}, height={1}, area={2}, color=\"{3}\"]", Width, Height, getArea(), Color);
        }
    }
}

