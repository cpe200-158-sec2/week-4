﻿using System;

namespace Lab4
{
	public abstract class Shape
	{
        private string _color;
        public abstract double getArea();
        public abstract double getPerimeter();
        public string Color
        {
            get
            {
                return _color;
            }
        }
     
		public Shape (string c="gold")
		{
            _color=c;
		}
        

        public override string ToString()
        {
            string st;
            st = "[Color:" + Color + "]";
            return st;
        }

    }
}

