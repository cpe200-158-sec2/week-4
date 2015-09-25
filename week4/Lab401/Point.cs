using System;

namespace Lab4
{
	public class Point
	{
        private double x, y;
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

        public Point ()
		{
            X = 0;
            Y = 0;
		}
        public Point(Point a)
        {
            this.X = a.X;
            this.Y = a.Y;
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            string answer = "[Circle: center(" + X + "," + Y + ")]";
            return answer;
        }
    }
}

