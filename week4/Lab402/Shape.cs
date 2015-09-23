﻿using System;

namespace Lab4
{
    public abstract class Shape
    {
        private string _color = "gold";
        public Shape(string color)
        {
            _color = color;
        }
        public string Color
        {
            get { return _color; }
        }
        public abstract double getArea();
        public abstract double getPerimeter();
        public override string ToString()
        {
            return string.Format("{0}", Color);
        }


    }
}

