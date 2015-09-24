using System;

namespace Lab401
{
    public class Point
    {

            private double _x;
            private double _y;

        public double A
        {
            get { return _x; }
            set { _x = value; }
        }
        public double B
        {
            get { return _y; }
            set { _y = value; }
        }
        public Point()
        {
            this.A = 0;
            this.B = 0;
        }
        public Point(Point a)
        {
            this.A = a.A;
            this.B = a.B;
        }
        public Point(double a,double b)
        {
            this.A = a;
            this.B = b;
        }
    }

}
        


