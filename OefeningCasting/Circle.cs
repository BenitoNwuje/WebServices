using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningCasting
{
    class Circle
    {
        private int radius;
        public double Area
        {
            get
            {
                return radius * radius * Math.PI;
            }
        }
        public Circle(int radius)
        {
            this.radius = radius;
        }
    }
}
