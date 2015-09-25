using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _h;
        public double H
        {
            get
            {
                return _h;
            }
            set
            {
                _h = (value >= 0) ? value : 1.0;
            }
        }

		public Cylinder ()
		{
            X = 0.0;
            Y = 0.0;
            R = 1.0;
            H = 1.0;
		}
        public Cylinder(double c,double d)
        {
            X = 0.0;
            Y = 0.0;
            R = c;
            H = d;
        }
        public Cylinder(double a,double b,double c,double d)
        {
            X = a;
            Y = b;
            R = c;
            H = d;
        }
        public Cylinder(Circle a)
        {
            X = a.X;
            Y = a.Y;
            R = a.R;
            H = 1;
        }
        public Cylinder(Cylinder a)
        {
            X = a.X;
            Y = a.Y;
            R = a.R;
            H = a.H;
        }

        public override double getArea()
        {
            return base.getArea() * 2.0 + 2.0 * Math.PI * R * H;
        }
        public double getVolume()
        {
            return base.getArea() * H;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center({0},{1}), radius={2}, height={3}, surface={4}, volume={5}]", this.X, this.Y, this.R, this.H, getArea(), getVolume());
        }
    }
}

