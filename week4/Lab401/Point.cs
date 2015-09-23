using System;

namespace Lab4
{
	public class Point
	{
        //Propeties
        private double _x, _y;

        //Constructors
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

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        public Point(double a,double b)
        {
            this.x = a;
            this.y = b;
        }

        //Methods
        public override string ToString()
        {
            string s = "(" + x + "," + y + ")";
            return s;
        }
    }
}

