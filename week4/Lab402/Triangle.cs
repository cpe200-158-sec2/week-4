using System;

namespace Lab4
{
    public class Triangle : Shape
    {
        private double width;

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0) width = 1;
                else width = value;
            }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0) height = 1;
                else height = value;
            }
        }

        public Triangle()
        {
            Width = 1;
            Height = 1;    
        }

        public Triangle(string c , double x , double y )
        {
            Width = x;
            Height = y;
            color = c;
        }

        public Triangle(Triangle a)
        {
            Width = a.Width;
            Height = a.Height;
            color = a.color;
        }

        public override double getArea()
        {
            return Height * Width / 2;
        }
        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width) + (Height * Height));
        }
        public override string ToString()
        {
            return string.Format("[Triangle : base={0}, height={1}, area={2}, color=" + color + "]", this.Width, this.Height, this.getArea());
        }



    }
}

