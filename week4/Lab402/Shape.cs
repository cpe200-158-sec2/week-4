using System;

namespace Lab402
{
    public abstract class Shape
    {
        private string _color;
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Shape(string color = "gold")
        {
            _color = color;
        }

        public abstract double getArea();
        public abstract double getPerimeter();
        public override string ToString()
        {
            return string.Format("0", Color);
        }

    }
}
