using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;
        private string color;

        public Rectangle(double length, double width, string color)
        {
            this.length = length;
            this.width = width;
            this.color = color;
        }

        public override double Area()
        {
            return length*width;
        }
    }
}
