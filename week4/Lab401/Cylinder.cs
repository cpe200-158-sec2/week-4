using System;

namespace Lab401
{
    public class Cylinder : Circle
    {

        private double _hight;
        private double Hight;
        
            public double hight
        {
            get { return _hight; }
            set
            {
                if (value >= 0)
                {
                    _hight = value;

                }
            }

        }
        public Cylinder()
        {
            this.Hight = 1.0;
        }
        public Cylinder(Circle c)
        {
            base.setCircle(c.A, c.B, c.Radius);
            this.Hight = 1.0;
        }
        public Cylinder(double r, double h)
        {
            this.Hight = h;
            this.Radius = r;

        }
        public Cylinder(double x, double y, double r, double h)
        {
            base.setCircle(x, y, r);
            this.Hight = h;
        }

        public Cylinder(Cylinder cy)
        {
            base.setCircle(cy.A, cy.B, cy.Radius);
            this.Hight = 1.0;

        }
        public override double getArea()
        {
            return base.getArea() * 2 + 2 * Pi * Radius * Hight;
        }
        public double getVolume()
        {
            return base.getArea()*Hight;
        }
        public override string ToString()
        {
            string gg = "[Cylinder : center(" + A + "," + B + ", radius=" + Radius + ", height=" + hight + ", surface=" + getArea() + ", volume =" + getVolume() + "]";
            return gg;
        }
       
    }
}

