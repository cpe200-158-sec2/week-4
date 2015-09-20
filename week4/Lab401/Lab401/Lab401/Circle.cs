using System;

namespace Lab4
{
    public class Circle : Point
    {
        private Point _Center = new Point();
        private double _Radius;

        public Point Center
        {
            get { return _Center; }
        }
        public double Radius
        {
            get { return _Radius; }
            set
            {
                if (value < 0)
                {
                    _Radius = 1;
                }
                else
                {
                    _Radius = value;
                }
            }
        }
        public Circle()
        {
            this.Radius = 1;
        }

        public Circle(double c)
        {
            this.Radius = c;
        }

        public Circle(double x, double y, double c)
        {
            this._Center.x = x;
            this._Center.y = y;
            this.Radius = c;
        }

        public Circle(Circle c)
        {
            this._Center.x = c._Center.x;
            this._Center.y = c._Center.y;
            this.Radius = c.Radius;
        }
        public void setCircle(double a, double b, double c)
        {
            this._Center.x = a;
            this._Center.y = b;
            this.Radius = c;
        }

        public virtual double getArea()
        {
            double area;
            area = Math.PI * this.Radius * this.Radius;
            return area;
        }

        public override string ToString()
        {
            string e = "[Circle: center(" + this.Center.x + "," + this.Center.y + "), raduis=" + this.Radius + ", area =" + this.getArea() + "]";
            return e;
        }

    }
}

