using System;

namespace Lab4
{
	public class Circle : Point
	{
        private double _radius;
        public Point _center = new Point();
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                {
                    _radius = 1.0;
                }
                else
                {
                    _radius = value;
                }
            }
        }
		public Circle ()
		{
            _center.X = 0;
            _center.Y = 0;
            Radius = 1.0;
		}
        public Circle(double r)
        {
            Radius = r;
        }

        public Circle(double x,double y,double r)
        {
            _center.X = x;
            _center.Y = y;
            Radius = r;

        }

        public Circle(Circle a)
        {
            _center.X = a._center.X;
            _center.Y = a._center.Y;
            Radius = a.Radius;
        }

        public void setCircle(double x, double y,double r)
        {
            _center.X = 0;
            _center.Y = 0;
            Radius = 1.0;
        }

        public double getArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public override string ToString()
        {
            return string.Format("Circle: center(" + _center.X + "," + _center.Y + "), radius=" + Radius + ", area=" + getArea() + "]");
        }
    }
}

