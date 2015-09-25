using System;

namespace Lab4
{
	public class Point
	{
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point (Point N)
        {
            this.X = N.X;
            this.Y = N.Y;
        }
        public Point (double x,double y)
        {
            X = x;
            Y = y;
        }
	}
}

