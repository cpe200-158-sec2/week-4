﻿using System;

namespace Lab4
{
    public abstract class Shape
    {
        public abstract double getArea();
        public abstract double getPerimeter();

        private string _c;
        public string Color
        {
            get { return _c; }
            set { _c = value; }
        }

        public Shape(string a = "gold")
        {
            _c = a;
        }

        public override string ToString()
        {
            return string.Format("{0},Color");
        }
    }
}

