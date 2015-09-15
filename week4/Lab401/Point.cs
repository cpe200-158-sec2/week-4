using System;

namespace Lab4
{
	public class Point
	{
        //Private Properties
        private double _x, _y;

        //Public Properties
        public double x
        {
            get { return _x; }
            set { _x = value; }
        }
        public double y
        {
            get { return _y; }
            set { _y = value; }
        }

        //Constructors
        public Point ()
		{
            _x = 0;
            _y = 0;
		}
        public Point (Point i)
        {
            _x = i.x;
            _y = i.y;
        }
        public Point (double x, double y)
        {
            _x = x;
            _y = y;
        }

        //methods
        public override string ToString()
        {
            return string.Format("center({0},{1})", this.x, this.y);
        }
    }
}

