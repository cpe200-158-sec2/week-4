using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private double Height;

        public double height
        {
            get { return Height; }
            set { if (value >= 0) Height = value;
                else Height = 1;
            }
        }

        public Cylinder ()
		{
            setCircle(0, 0, 1);
            height = 1;
		}

        public Cylinder (double r , double h)
        {
            setCircle(0, 0, r);
            height = h;
        }

        public Cylinder(double a , double b , double r, double h)
        {
            setCircle(a, b, r);
            height = h;
        }

        public Cylinder(Circle a)
        {
            setCircle(a.C.x , a.C.y , a.radius);
            height = 1;
        }

        public Cylinder(Cylinder a)
        {
            setCircle(a.C.x, a.C.y, a.radius);
            height = a.height;
        }

        public override double getArea()
        {
            return (2*Math.PI*radius * Height) + (base.getArea() *2) ;               
        }

        public double getVolume()
        {
            return base.getArea() * height;
        }

        public override string ToString()
        {
            return string.Format("[Cylinder: center{0}, radius={1}, height={2}, surface={3}, volume={4}]", base.C , base.radius , height , getArea() , getVolume () );
        }

    }
}

