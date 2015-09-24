using System;

namespace Lab402
{
	public abstract class Shape
	{

        private string _color;
        public string color
        {
            get { return _color; }
        }
        public Shape (string color = "gold")
        {
            _color = color;
        }
        public override string ToString()
        {
            return string.Format(_color);
        }
        public abstract double getArea();
        public abstract double getPerimeter();

        // string Color: read-only, color of the shape, default="gold"

    }
}

