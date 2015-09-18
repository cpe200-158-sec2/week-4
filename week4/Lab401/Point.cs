using System;

namespace Lab4
{
	public class Point
	{
        private double _x = 0;
        private double _y = 0;
        public double X
        {
            set { if (value >= 0) _x = value; }
            get { return _x; }
        }
        public double Y
        {
            set { if (value >= 0) _y = value; }
            get { return _y; }
        }
        public Point ()
		{
            X = 0;
            Y = 0; 
        }
        public Point(Point a)
        {
            X = a.X;
            Y = a.Y;
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return string.Format("{{0},{1}}", X,Y);
        }
    }
}
