using System;

namespace Lab4
{
	public class Circle : Point
	{
        private double _r;
        public double R
        {
            get
            {
                return _r;
            }
            set
            {
                _r = (value >= 0) ? value : 1;
            }
        }

		public Circle()
		{
            X = 0.0;
            Y = 0.0;
            R = 1.0;
		}
        public Circle(double c)
        {
            X = 0.0;
            Y = 0.0;
            R = c;
        }
        public Circle(double a,double b,double c)
        {
            X = a;
            Y = b;
            R = c;
        }
        public Circle(Circle a)
        {
            X = a.X;
            Y = a.Y;
            R = a.R;
        }

        public void setCircle(double a,double b,double c)
        {
            this.X = a;
            this.Y = b;
            this.R = c;
        }
        public virtual double getArea()
        {
            return (Math.PI * this.R * this.R);
        }
        public override string ToString()
        {
            return string.Format("[Circle: center({0},{1}), radius={2}, area={3}]", this.X, this.Y, this.R, getArea());
        }
    }
}

