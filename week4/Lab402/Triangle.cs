using System;

namespace Lab402
{
    public class Triangle : Shape
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
       public Triangle()
        {
            this.width = 1.0;
            this.hight = 1.0;
        }
        public Triangle (string color ,double w, double h) :base(color){
            this.width = w;
            this.hight = h;
        }
        public Triangle (Rectangle a) : base(a.color)
        {
            this.width = a.width;
            this.hight = a.hight;
        }
        public override double getArea()
        {
            return (width * hight) / 2; 
        }
        public override double getPerimeter()
        {
            return width + hight + (Math.Sqrt(Math.Pow(width, 2) + Math.Pow(hight, 2)));
        }
        public override string ToString()
        {
           string kk = "[Triangle: base =" + width + ", height = " + hight + ", area = " + getArea() + ", color = " + color + "]";
           return kk;
        }
        




    }

    //[Triangle: base=4, height=5, area=10, color="blue"]
    //## Properties:
    //- double Width, Height: dimension of rectangle(>0, default=1.0)

    //## Constructors:
    //- Triangle(): default
    //- Triangle(string, double, double): takes color, width, height as parameters
    //- Triangle(Rectangle): copy constructor

    //## Methods:
    //- getArea(): get area of a triangle
    //- override ToString() method
}

