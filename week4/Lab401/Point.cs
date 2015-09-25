using System;

namespace Lab4
{
    public class Point
    {

        private double _x;
        private double _y;
        public Point()
        {

            X = 0;
            Y = 0;
        }

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
        public Point(Point a)
        {
            X = a._x;
            Y = a._y;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {

            return string.Format("{{0},{1}}", X, Y);
        }
    }
}
