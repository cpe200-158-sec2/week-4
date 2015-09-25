using System;

namespace Lab4
{
	public class Circle
	{
        private Point _Center;
        private double _Radius = 1.0;

        public double Radius
        {
            get
            {
                return _Radius;
            }

            set
            {
                _Radius = value;
            }
        }
        public Point Center
        {
            get
            {
                return _Center;
            }

            set
            {
                _Center = value;
            }
        }

        public Circle ()
		{
            setCircle(0, 0, 1);
        }

        public Circle (double a)
        {
            setCircle(0, 0, a);
        }

        public Circle (double a , double b, double c)
        {
            setCircle(a, b, c);
        }

        public Circle (Circle a)
        {
            setCircle(a.Center.X, a.Center.Y, a.Radius);
        }

        public void setCircle(double a,double b,double r)
        {
            _Center = new Point(a,b);
            Radius = r;
        }

        public double getArea()
        {
            return 3.14159265358979 * Radius * Radius;
        }

        public override string ToString()
        {
            return "[Circle: center(" + Center.X + "," + Center.Y + "), radius=" + Radius+", area="+getArea()+"]";
        }


    }
}

