using System;

namespace Lab4
{

    public class Circle : Point 
    {
        
        public Point Center = new Point();
        private double _radius;

        public double Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                if (value >= 0)
                {
                    _radius = value;
                }
                else
                {
                    _radius = 1.0;
                }

            }
        }

        //constructor
        public Circle()
        {
            Radius = 1.0;
        }
        public Circle(double r)
        {
            Radius = r;
        }
        public Circle(double x, double y, double r)
        {
            Radius = r;
            Center.X = x;
            Center.Y = y;
        }
        public Circle(Circle a)
        {
            Radius = a.Radius;
            Center.X = a.Center.X;
            Center.Y = a.Center.Y;
        }

        public void setCircle(double x, double y, double r)
        {
            Radius = r;
            Center.X = x;
            Center.Y = y;
        }
        public virtual double getArea()
        {
            double area = Math.Pow(Radius, 2) * Math.PI;
            return area;
        }
        public override string ToString()
        {
            string output = ("[Circle: center(" + Center.X + "," + Center.Y + "), radius=" + Radius + ", area=" + getArea() + "]");
            return output;
        }
    }
}

