using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{
    public interface IShape
    {
        // these are abstract method (Without implementation)
        // so in interface the members are all abstract members
        // but we dont use keyword abstract here 
        double Area();
        double Perimeter();
    }
}
