using System;

namespace Lab4
{
    public class Rectangle : Shape
    {


        public Rectangle() : base("gold")
        {
            Width = 1;
            Height = 1;
        }

        public Rectangle(string c, double w, double h) : base(c)
        {
            Width = w;
            Height = h;
        }

        public Rectangle(Rectangle rec) : base(rec.Color)
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
            return Width + Width + Height + Height;
        }

        public override string ToString()
        {
            return "[Rectangle: width=" + Width + ", height=" + Height + ", area=" + getArea() + ", color=\"" + Color + "\"]";
        }

    }
}
//# 2. Rectangle Class:

//## Properties:
//- double Width, Height: dimension of rectangle(>0, default=1.0)

//## Constructors:
//- Rectangle(): default
//- Rectangle(string, double, double): takes color, width, height as parameters
//- Rectangle(Rectangle): copy constructor

//## Methods:
//- getArea(): get area of a rectangle
//- override ToString() method [Rectangle: width=4, height=5, area=20, color="red"]




