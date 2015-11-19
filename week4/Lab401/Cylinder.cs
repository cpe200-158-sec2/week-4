using System;

namespace Lab4
{
	public class Cylinder : Circle
	{

        //Properties
        private double _Height;

        public double Height
        {
            get { return _Height; }
            set
            {
                if (value < 0)
                {
                    _Height = 1;
                }
                else
                {
                    _Height = value;
                }
            }
        }

        //Constructors
        public Cylinder ()
		{
            this.Height = 1;
        }

        public Cylinder (double r, double h)
        {
            this.Radius = r;
            this.Height = h;
        }

        public Cylinder (double a, double b, double r, double h)
        {
            base.setCircle(a, b, r);
            this.Height = h;
        }

        public Cylinder (Circle c)
        {
            base.setCircle(c.Center.x, c.Center.y,c.Radius);
            this.Height = 1;
        }

        public Cylinder(Cylinder cy)
        {
            base.setCircle(cy.Center.x, cy.Center.y, cy.Radius);
            this.Height = cy.Height;
        }

        //Methods
        public override double getArea()
        {
            double area=0;
            area = (2* base.getArea()) + (2 * Math.PI * this.Radius * this.Height) ;
            return area;
        }

        public double getVolume()
        {
            double volume = 0;
            volume = (base.getArea() * this.Height) ;
            return volume;
        }

        public override string ToString()
        {
            string s = "[Cylinder: center(" + this.Center.x + "," + this.Center.y + "), raduis=" + this.Radius + ", height=" + this.Height + ", surface =" + this.getArea() + ", volume =" + this.getVolume() + "]";
            return s;
        }
    }
}
