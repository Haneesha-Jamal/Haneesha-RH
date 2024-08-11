using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNow.Model
{
    
    public class JobSeeker
    {
        

        private Job[] AppliedJobs = new Job[10];
        private Job[] SavedJobs = new Job[10];
        public int id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string Qualification { get; set; }
        public string ExperianceLevel { get; set; }
        public string Password { get; set; }

        public void addAppliedJob(Job job)
        {

        }

        public Job[] GetAppliedJob()
        {
            return AppliedJobs;
        }
        public void addSavedJob(Job job)
        {

        }
        public Job[] GetSavedJob()
        {
            return SavedJobs;
        }

    }
}
