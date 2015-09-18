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
            _x = 0.0;
            _y = 0.0;
		}
        public Point (Point a)
        {
            _x = a.X;
            _y = a.Y;
        }
        public Point (double a, double b)
        {
            _x = a;
            _y = b;
        }
        public override string ToString()
        {
            return string.Format("({0},{1})",X,Y);
        }
    }
}

