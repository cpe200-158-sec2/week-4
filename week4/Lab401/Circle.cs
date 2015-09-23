using System;

namespace Lab4
{
	public class Circle : Point
	{
        private double _radius;
        private Point _center;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (_radius <= 0)
                {
                    _radius = 1.0;
                }
                else
                {
                    _radius = value;
                }
            }
        }
        public Point Center
        {
            get
            {
                return _center;
            }
            set
            {
                _center = value;
            }
        }
		public Circle ()
		{
            _radius = 1.0;
            _center = new Point();
		}
        public Circle(double r)
        {
            _radius = r;
            _center = new Point();
        }
        public Circle (double a,double b, double r)
        {
            _center = new Point(a, b);
            _radius = r;
        }
        public Circle (Circle c)
        {
            _center = c.Center;
            _radius = c.Radius;
        }
        public void setCircle(double a, double b, double r)
        {
            _radius = r;
            _center = new Point(a, b);
        }
        public virtual double getArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return string.Format("[Circle: center{0}, radius={1}, area={2}]",Center,_radius,getArea());
        }
    }
}

