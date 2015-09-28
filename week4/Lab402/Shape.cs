using System;

namespace Lab4
{
	public abstract class Shape
	{
        //Private Properties
        private readonly string _Color;

        //Public Properties
        public string Color
        {
            get { return _Color; }
        }

        //Constructors
		public Shape (string C = "gold")
		{
            _Color = C;
		}

        //Methods
        public abstract double getArea();
        public abstract double getPerimeter();
        public override string ToString()
        {
            return string.Format("{0}", Color);
        }
    }
}

