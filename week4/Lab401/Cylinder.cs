using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        //Private Properties
        private double _Height;
        private Circle _Circle;

        //Public Properties
        public double Height
        {
            get { return _Height; }
            set { _Height = (value < 0) ? 1 : value; }
        }
        public Circle Circle
        {
            get { return _Circle; }
            set { _Circle = value; }
        }

        //Constructors
		public Cylinder ()
		{
            _Circle = new Circle();
            _Height = 1;
		}
        public Cylinder (double r, double h)
        {
            _Circle = new Circle(r);
            _Height = h;
        }
        public Cylinder (double x, double y, double r, double h)
        {
            _Circle = new Circle(x, y, r);
            _Height = h;
        }
        public Cylinder (Circle i)
        {
            _Circle = new Circle(i);
            _Height = 1;
        }
        public Cylinder (Cylinder i)
        {
            _Circle = new Circle(i.Circle);
            _Height = i.Height;
        }

        //Methods
        public override double getArea()
        {
            return this.Circle.getArea();
        }
        public double getVolume()
        {
            return this.getArea() * this.Height;
        }
        public double getSurface() //Extra Method - Get Surface
        {
            return (2 * Math.PI * this._Circle.Radius * this._Height) + (2 * this.getArea());
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: {0}, radius={1}, height={2}, surface={3}, volume={4}]", _Circle.Center, _Circle.Radius, _Height, this.getSurface(), this.getVolume());
        }
    }
}

