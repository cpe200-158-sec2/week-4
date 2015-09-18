using System;

namespace Lab4
{
	public class Circle
	{
        private Point _Center;
        private double _radius;
        public double radius
        {
            get { return _radius; }
            set {
                if (value >= 0)
                    _radius = value;
                else
                    _radius = 1;
                }
        }
        public Point Center
        {
            get { return _Center; }
            set { _Center = value; }
        }
        public Circle ()
		{
            _Center = new Point();
            radius = 1;
		}
        public Circle (double a)
        {
            _Center = new Point();
            radius = a;
        }
        public Circle(double a,double b,double c)
        {
            _Center = new Point(a, b);
            radius = c;
        }
        public Circle (Circle a)
        {
            _Center = a._Center;
            radius = a.radius;               
        }
        public double getArea()
        {
            return Math.PI * _radius * _radius;
        }
        public override string ToString()
        {
            return string.Format("[Circle: center{0}, radius={1}, area = {2}]", _Center, _radius, getArea());
        }

    }
}

