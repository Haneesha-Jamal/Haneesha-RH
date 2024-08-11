using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Shape
    {
        public abstract double Area();
        public void DisplayColor(string color)
        {
            Console.WriteLine("The color is : " +color);
        }
    }
}
