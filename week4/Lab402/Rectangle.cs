using System;

namespace Lab402
{
    public class Rectangle :Shape
    {
        private double _width;
        private double _hight;

        public double width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    _width = 1.0;
                }
            }
        }
        public double hight
        {
            get { return _hight; }
            set
            {
                if (value > 0)
                {
                    _hight = value;
                }
                else
                {
                    _hight = 1.0;
                }
            }
        }

        public Rectangle()
        {
            this.hight = 1;
            this.width = 1;
        }
        public Rectangle(string color, double w,double h) :base(color)
        {
            this.width = w;
            this.hight = h;
        }
        public Rectangle (Rectangle a) : base(a.color)
        {
            this.width = a.width;
            this.hight = a.hight;
        }

        public override double getArea()
        {
            return width * hight;
        }
        public override double getPerimeter()
        {
            return (width + width) + (hight + hight);
        }

        public override string ToString()
        {
            string ii =  "[Rectangle: width = "+width+", height = "+hight+", area = " + getArea() + ", color = " + color + "]";
                return ii;

        }

        // [Rectangle: width=4, height=5, area=20, color="red"]
        //## Properties:
        //- double Width, Height: dimension of rectangle(>0, default=1.0)

        //## Constructors:
        //- Rectangle() : default
        //- Rectangle(string, double, double) : takes color, width, height as parameters
        //- Rectangle(Rectangle) : copy constructor

        //## Methods:
        //- getArea(): get area of a rectangle
        //- override ToString() method
    }
}

