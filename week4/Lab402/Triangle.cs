using System;

namespace Lab402
{
    public class Triangle : Shape
    {
        private double width = 1;
        private double height = 1;

        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    width = 1;
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    height = 1;
                }
            }
        }

        public Triangle()
        {
            
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

