using System;

namespace Lab4
{
	public abstract class Shape
	{
        private string _Color = "gold";
        public string Color
        {
            get
            {
                return _Color;
            }

            set
            {
                _Color = value;
            }
        }

        public Shape()
		{

		}

        public Shape(string a)
        {
            Color = a;
        }


        
        public abstract double getArea();
        public abstract double getPerimeter();


    }
}

