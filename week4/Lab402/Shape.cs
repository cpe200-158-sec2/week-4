using System;

namespace Lab402
{
    public abstract class Shape
    {
        private string color;

        public string Color
        {
            get { return color; }
        }

        public Shape(string c = "gold")
        {
            color = c;
        }

        public abstract double getArea();
        public abstract double getPerimeter();

        public override string ToString()
        {
            return Color;
        }

    }
}

