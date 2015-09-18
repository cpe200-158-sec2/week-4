using System;

namespace Lab4
{
	public class Cylinder : Circle
    {
        private double height;
        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0) height = value;
                else height = 1.0;
            }
        }
        public Cylinder()
        {
            Height = 1.0;
        }
        public Cylinder(double r, double h)
        {
            Height = h;
            Radius = r;
        }
        public Cylinder(double x, double y, double r, double h)
        {
            Height = h;
            base.setCircle(x, y, r);
        }
        public Cylinder(Circle a)
        {
            Height = 1.0;
            base.setCircle(a.X, a.Y, a.Radius);
        }
        public Cylinder(Cylinder A)
        {
            Height = A.Height;
            base.setCircle(A.X, A.Y, A.Radius);
        }

        public override double getArea()
        {
            return base.getArea() * 2 + 2 * Math.PI * Radius * Height;
        }
        public double getVolume()
        {
            return base.getArea() * Height;
        }

        public override string ToString()
        {
            string answer = "[Cylinder: center(" + X + "," + Y + "), radius=" + Radius + ", height=" + Height + ", surface=" + getArea() + ", volume=" + getVolume() + "]";
            return answer;
        }
    }
}

