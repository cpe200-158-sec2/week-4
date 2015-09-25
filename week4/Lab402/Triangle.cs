using System;

namespace Lab4
{
    public class Triangle : Shape
    {

        public Triangle() : base("gold")
        {
            Width = 1.0;
            Height = 1.0;
        }

        public Triangle(string color, double w, double h) : base(color)
        {
            Width = w;
            Height = h;
        }

        public Triangle(Triangle rec) : base(rec.Color)
        {
            Width = rec.Width;
            Height = rec.Height;
        }

        public override double getArea()
        {
            return Width * Height;
        }

        public override double getPerimeter()
        {
            return Width + Height + Math.Sqrt((Width * Width + Height * Height));
        }

        public override string ToString()
        {
            return "[Triangle: base=" + Width + ", height=" + Height + ", area=" + getArea() + ", color=\"" + Color + "\"]";
        }
    }
}
//# 3. Triangle Class:

//## Properties:
//- double Width, Height: dimension of rectangle(>0, default=1.0)

//## Constructors:
//- Triangle(): default
//- Triangle(string, double, double): takes color, width, height as parameters
//- Triangle(Rectangle): copy constructor

//## Methods:
//- getArea(): get area of a triangle
//- override ToString() method [Triangle: base=4, height=5, area=10, color="blue"]



