using System;

namespace Lab4
{
	public class Circle
	{
        public Point Center { get; set; }

        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value >= 0)
                    radius = value;
                else radius = 1.0;
            }
        }

        public Circle ()
		{
            setCircle(0, 0, 1.0);
		}
        public Circle(double r)
        {
            setCircle(0, 0, r);
        }
        public Circle(double x, double y, double r)
        {
            setCircle(x, y, r);
        }
        public Circle(Circle tmp)
        {
            setCircle(tmp.Center.x,tmp.Center.y,tmp.radius);
        }

        public void setCircle(double x, double y, double r)
        {
            Center = new Point(x, y);
            this.radius = r;
        }

        public virtual double getArea()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return "[Circle: center" + Center + ", radius=" + radius + ", area=" + getArea() + "]";
        }
    }
}
//# 2. Circle Class:
//## Properties:
//- Point Center: a point represent the center of a circle(use Point class)
//- double Radius: radius of a circle(>=0, default=1.0)

//## Constructors:
//- Circle(): default
//- Circle(double): takes radius as a paramenter
//- Circle(double, double, double): takes x, y, radius as parameters
//- Circle(Circle): copy constructor

//## Methods:
//- setCircle(double, double, double): take x, y, radius as parameters
//- getArea(): virtual, get area of a cicle
//- override ToString() method [Circle: center(0,0), radius=1, area=3.14159265358979]



