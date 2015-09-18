using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double _height;
        private Circle _circle;
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (_height <= 0)
                {
                    _height = 1.0;
                }
                else
                {
                    _height = value;
                }
            }
        }
		public Cylinder ()
		{
            _height = 1.0;
            _circle = new Circle();
		}
        public Cylinder (double r,double h)
        {
            _circle.Radius = r;
            _height = h;
        }
        public Cylinder (double a, double b, double r, double h)
        {
            _height = h;
            _circle = new Circle(a, b, r);
        }
        public Cylinder (Circle c)
        {
            _height = 1.0;
            _circle = new Circle(c);
        }
        public Cylinder (Cylinder a)
        {
            _height = a.Height;
            _circle = new Circle(a._circle.Center.X, a._circle.Center.Y, a._circle.Radius);
        }
        public override double getArea()
        {
            return (2 * _circle.getArea()) + (Height * 2 * Math.PI * _circle.Radius);
        }
        public  double getVolume()
        {
            return _circle.getArea() * Height;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center{0}, radius={1}, height={2}, surface={3}, volume={4}]",_circle.Center,_circle.Radius,Height,getArea(),getVolume());
        }
    }
}

