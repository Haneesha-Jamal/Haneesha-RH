using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractionUsingAbstractClass
{
     class UnderGraduate: Student
    {
        public string Major {  get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"UnderGraduate Student \n Name : {Name} \n Age : {Age} \n Major : {Major}");
        }
    }
}
