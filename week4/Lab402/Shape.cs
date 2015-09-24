using System;

namespace Lab4
{
	public abstract class Shape
	{

        private string Color;

        public string color
        {
            get { return Color; }
            set { Color = value; }
        }


        public Shape (string colour="Gold")
        {
            color = colour;
        }

        public abstract double getArea();
        public abstract double getPerimeter();
        public abstract override string ToString();
    }
}

