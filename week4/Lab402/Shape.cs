using System;

namespace Lab4
{
	public abstract class Shape
	{
        //member
        public abstract double getArea();
        public abstract double getPerimeter();

        protected string _color ; //private string _color;

        //properties
        public string Color //read noly
        {
            get { return _color; }
        }

        //constructor default = "gold"
        public Shape(string c = "gold")
        {
            _color = c;
        }

        //override
        public override string ToString()
        {
            return string.Format("{0}", Color);
        }



    }
}

