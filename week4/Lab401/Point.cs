using System;

namespace Lab4
{
	public class Point
	{
        private double X;

        public double x
        {
            get { return X; }
            set { X = value; }
        }

        private double Y;

        public double y
        {
            get { return Y; }
            set { Y = value; }
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
        }

        public Point(double a , double b)
        {
            x = a;
            y = b;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", x, y);
        }

    }
	
}

