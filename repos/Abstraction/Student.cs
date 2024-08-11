using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //abstract method for displaying student information

        public abstract void DisplayInfo();
    }
}
