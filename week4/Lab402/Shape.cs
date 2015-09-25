using System;

namespace Lab4
{
	public abstract class Shape
	{
        public string color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        private string _color;
		public Shape (string color = "gold")
		{
            _color = color;
		}
        public override abstract string ToString();
        
        public abstract double getArea();

        public abstract double getPerimeter();
        
    }
}

