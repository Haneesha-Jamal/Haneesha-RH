using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Circle : Shape
    {
        private double radius;
        private string color;

        
        public Circle(string color,double radius)
        {
            this.color = color;
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        
    }
}
