using System;

namespace Lab4
{
	public abstract class Shape
	{
        public abstract double getArea();
        public abstract double getPerimeter();

        protected string _c;
        public string Color
        {
            get { return _c; }
        }

		public Shape(string a = "gold")
		{
            _c = a;
		}

        public override string ToString()
        {
            return string.Format("{0},Color");
        }
    }
}

