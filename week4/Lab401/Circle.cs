using System;

namespace Lab4
{
	public class Circle : Point
	{
        //Priavte Properties
        private Point _Center;
        private double _Radius;
        
        //Public Properties
        public Point Center
        {
            get { return _Center; }
            set { _Center = value; }
        }
        public double Radius
        {
            get { return _Radius; }
            set { _Radius = (value < 0) ? 1 : value; }
        }

        //Constructors
		public Circle ()
		{
            _Center = new Point();
            _Radius = 1;
		}
        public Circle (double r)
        {
            _Center = new Point();
            _Radius = r;
        }
        public Circle (double x, double y, double r)
        {
            _Center = new Point(x, y);
            _Radius = r;
        }
        public Circle (Circle i)
        {
            _Center = i.Center;
            _Radius = i.Radius;
        }

        //Methods
        public void setCircle (double x, double y, double r)
        {
            this._Center = new Point(x, y);
            this._Radius = r;
        }
        public virtual double getArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
        public override string ToString()
        {
            return string.Format("[Circle: {0}, radius={1}, area={2}]", _Center, _Radius, this.getArea());
        }
    }
}

