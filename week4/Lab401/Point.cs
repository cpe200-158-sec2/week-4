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

        public Point ()
		{
		}
        public Point (Point a)
        {
            X = a.X;
            Y = a.Y;
        }
        public Point (double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

