using System;

namespace Lab4
{
    public abstract class Shape
    {
        private string color = "gold";

        private double width = 1.0;

        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                    width = value;
                else width = 1;
            }
        }

        private double height = 1.0;

        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else height = 1;
            }
        }
        public string Color
        {
            get { return color; }
        }

        public Shape(string color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public abstract double getArea();
        public abstract double getPerimeter();
    }
}
//# 1. Shape Class:
//Abstract class

//## Propeties:
//- string Color: read-only, color of the shape, default="gold"

//## Constructors:
//- no default constructor
//- Shape(string): takes color as a parameter

//## Methods
//- overriding ToString()
//- getArea(): abstract method, calculate area of the shape
//- getPerimeter(): abstract method, calculate perimeter of the shape

