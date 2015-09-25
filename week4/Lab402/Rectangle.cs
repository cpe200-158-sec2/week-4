using System;

namespace Lab402
{
    public class Rectangle : Shape
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
                    width =value;
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

        public Rectangle()
        {
            
        }

        public Rectangle(string color, double w, double h) : base(color)
        {
            this.Width = w;
            this.Height = h;
        }

        public Rectangle(Rectangle R) : base(R.Color)
        {
            this.Width = R.Width;
            this.Height = R.Height;
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
            perimeter = 2.0 * (this.Width + this.Height);
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
