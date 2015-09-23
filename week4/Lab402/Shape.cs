﻿using System;

namespace Lab402
{
	public abstract class Shape
	{
        protected string _color;
		public Shape (string c = "gold")
		{
            _color = c; 
		}
        public string Color
        {
            get
            {
                return _color;
            }
        }
        public abstract double getArea();
        public abstract double getPerimeter();
        public override string ToString()
        {
            return string.Format("{0}",_color);
        }
    }
}

