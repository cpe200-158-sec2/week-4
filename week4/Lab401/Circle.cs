using System;

namespace Lab4
{   
	public class Circle : Point 
	{
        private Point _center = new Point() ;
        private double _radius = 1.0;
        public double Radius
        {
            set { if (value >= 0) _radius = value; }
            get { return _radius; }
        }
		public Circle ()
		{
            setCircle(0.0, 0.0, 1.0);
        }
        public Circle(double a)
        {
            setCircle(0.0, 0.0, a);
        }
        public Circle(double a, double b, double c)
        {
            setCircle(a, b, c);
        }
        public Circle(Circle a)
        {
            setCircle(a.X, a.Y, a.Radius);
        }

         public void setCircle(double a, double b, double c)
        {
            if (a >= 0) X = a;
            else X = 0.0;
            if (b >= 0) Y = b;
            else Y = 0.0;
            if (c >= 0) Radius = c;
            else Radius = 1.0;
        }
        public virtual  double getArea()
        {
            return Radius *Radius * Math.PI;
        }
       
        public override string ToString()
        {
            return string.Format("[Circle: center({0}, {1}), radius={2}, area={3}]", X, Y,Radius ,getArea ());
        }
    }
}