using System;

namespace Lab4
{
	public class Cylinder : Circle
	{
        private Circle _cir;
        private double _hight;
        public double hight
        {
            get { return _hight; }
            set
            {
                if (value > 0)
                    _hight = value;
                else
                    _hight = 1;
            }
        }
        public Circle cir
        {
            get { return _cir; }
            set { cir = value; }
        }
		public Cylinder ()
		{
          
            hight = 1;
		}
        public Cylinder(double a,double b)
        {
           
            radius = a;
            hight = b;
        }
        public Cylinder(double a , double b , double c , double d )
        {
        
            Center.x =a;
            Center.y = b;
            radius = c;
            hight = d;
        }
        public Cylinder(Circle a)
        {
           
            Center.x = a.Center.x;
            Center.y = a.Center.y;
            radius = a.radius;
            hight = 1;
        }
        public Cylinder(Cylinder a)
        {

            Center.x = a.Center.x;
            Center.y = a.Center.y;
            radius = a.radius;
            hight = a.hight;
        }
        public double getArea()
        {
            return (Math.PI * radius * radius * 2) + (2 * Math.PI * radius * hight);
        }
        public double getVolume()
        {
            return Math.PI*radius*radius* hight;
        }
        public override string ToString()
        {
            return string.Format("[Cylinder: center({0}), radius={1}, height={2}, surface={3}, volume={4}]", Center,radius, _hight, getArea(), getVolume());
        }
    }
}

