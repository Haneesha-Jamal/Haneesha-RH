using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNow.Model
{
    public class Job
    {
        public int Id { get; set; }  
        public string Title { get; set; }
        public string ExperienceLevel { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public string JobType { get; set; }

        public Job()
        {

        }
    }
}
