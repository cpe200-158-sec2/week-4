using System;

namespace Lab4
{
	public class Point
	{
        private double _x, _y;

        public double X
        {
            set { _x = value; }
            get { return _x; }
        }
        public double Y
        {
            set { _y = value; }
            get { return _y; }
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }  

        public Point(Point input)
        {
            X = input.X;
            Y = input.Y;
        }

        public  Point(double x,double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
	}
}

