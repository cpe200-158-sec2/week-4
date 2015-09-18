using System;

namespace Lab4
{
	public class Point
	{
        private double _x,_y;
        public double X
        {
            get { return _x;}
            set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public Point ()
		{
            X = 0;
            Y = 0;
		}
        public Point(Point p)
        {
            this.X = p.X;
            this.Y = p.Y;
        }
        public Point(double a,double b)
        {
            X = a;
            Y = b;
        }
	}
}

