﻿using System;

namespace Lab4
{
    public abstract class Shape
    {
        private string _color;

        public string Color
        {
            get { return _color; }
        }

        public Shape(string c = "gold")
        {
            _color = c;
        }

        public abstract double getArea();
        public abstract double getPerimeter();

        public override string ToString()
        {
            return Color;
        }

    }
}


