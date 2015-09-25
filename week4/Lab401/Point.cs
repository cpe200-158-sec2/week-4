using System;

namespace Lab4
{
    public class Point
    {
  
        private double _x;
        private double _y;
       
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

        //constructors
        public Point()
        {
            _x = 0;
            _y = 0;
        }
        public Point(Point a)
        {
            _x = a._x;
            _y = a._y;
        }
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public override string ToString()
        {
            return string.Format(X + "," + Y);
        }
    }
}
