using System;

namespace Lab4
{
	public class Point
	{
        private double _x, _y;
        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public Point()
		{
            X = 0.0;
            Y = 0.0;
		}
        public Point(Point a)
        {
            X = a.X;
            Y = a.Y;
        }
        public Point(double a,double b)
        {
            X = a;
            Y = b;
        }

        public override string ToString()
        {
            return string.Format("center({0},{1})", X, Y);
        }
    }
}

