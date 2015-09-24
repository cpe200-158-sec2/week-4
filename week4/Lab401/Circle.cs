using System;

namespace Lab401
{
	public class Circle:Point
	{
        
        private double _Radius;

        public double Radius
        {
            get { return _Radius; }
            set
            {
                if( value >= 0)
                {
                    _Radius = value;
                }
                else { _Radius = 1.0;}    
            }
        }

        public void setCircle(double a, double b, double c)
        {
            x = a;
            y = b;
            Radius = c;

        }
     
        public Circle ()
		{
            setCircle(0,0,1);
        }
        public Circle(double a)
        {
            setCircle(0,0,a);
        }
        public Circle(double a,double b,double c)
        {
            setCircle(a, b, c);
        }
        public Circle(Circle a)
        {
            x = a.x;
            y = a.y;       
            Radius = a.Radius;
        }

        public virtual double getArea()
        {
            return Math.PI  * Radius * Radius;
        }

        public override string ToString()
        {
            return string.Format("[Circle: center({0},{1}), radius = {2}, area = {3}]",x,y,Radius,getArea());
        }
    }
}

