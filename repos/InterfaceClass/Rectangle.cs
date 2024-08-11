using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{
    public class Rectangle:IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width ,double height)
        {
            Width = width;
            Height = height;

        }

        public double Area()
        {
            return Width*Height;
        }
        public double Perimeter()
        {
            return 2*(Width*Height);
        }
    }
}
