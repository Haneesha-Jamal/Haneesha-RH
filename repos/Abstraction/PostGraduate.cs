using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractionUsingAbstractClass
{
     class PostGraduate: Student
    {
        public string ResearchArea { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"UnderGraduate Student \n Name : {Name} \n Age : {Age} \n Research Area : {ResearchArea}");
        }
    }
}
