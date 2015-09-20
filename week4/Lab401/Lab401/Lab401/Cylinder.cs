using System;

namespace Lab4
{
    public class Cylinder : Circle
    {
        Circle c = new Circle();

        private double _Height;

        public double Height
        {
            get { return _Height; }
            set
            {
                if (value < 0)
                {
                    _Height = 1;
                }
                else
                {
                    _Height = value;
                }
            }
        }

        public Cylinder()
        {
            this.Height = 1;
        }

        public Cylinder(double c, double h)
        {
            this.c = new Circle(c);
            this.Height = h;
        }

        public Cylinder(double x, double y, double c, double h)
        {
            this.c = new Circle(x, y, c);
            this.Height = h;
        }

        public Cylinder(Circle circle)
        {
            this.c = new Circle(circle);
            this.Height = 1;
        }

        public Cylinder(Cylinder cylinder)
        {
            this.c = new Circle(cylinder.c);
            this.Height = cylinder.Height;
        }
        public override double getArea()
        {
            double area = 0;
            area = (2 * Math.PI * this.c.Radius * this.c.Radius) + (2 * Math.PI * this.c.Radius * this.Height);
            return area;
        }

        public double getVolume()
        {
            double volume = 0;
            volume = (Math.PI * this.c.Radius * this.c.Radius * this.Height);
            return volume;
        }

        public override string ToString()
        {
            string e = "[Cylinder: center(" + this.c.Center.x + "," + this.c.Center.y + "), raduis=" + this.c.Radius + ", height=" + this.Height + ", surface =" + this.getArea() + ", volume =" + this.getVolume() + "]";
            return e;

        }

    }
}
