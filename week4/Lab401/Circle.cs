﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab401
{
    public class Circle : Point
    {
        private double _radius;
        public double radius
        {
            get { return _radius; }
            set { _radius = (value >= 0) ? value : 1.0; }
        }
        public Circle() : base(0, 0)
        {
            radius = 1.0;
        }
        public Circle(double r)
        {
            x = 0;
            y = 0;
            radius = r;
        }
        public Circle(double a, double b, double r)
        {
            x = a;
            y = b;
            radius = r;

        }
        public Circle(Circle C)
        {
            radius = C.radius;
            x = C.x;
            y = C.y;
        }
        public void setCircle(double a, double b, double r)
        {
            x = a;
            y = b;
            radius = r;
        }
        public virtual double getArea()
        {
            return Math.PI * radius * radius;
        }
        public override string ToString()
        {
            return String.Format("[Circle: center({0},{1}), radius={2}, area={3}]", this.x, this.y, this.radius, this.getArea());
        }

    }
}


