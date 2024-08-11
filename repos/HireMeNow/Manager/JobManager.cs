using HireMeNow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNow.Manager
{
    public class JobManager
    {
       // public JobManager() { }

       public Job[] post = new Job[5];
        public int jobCount = 0;
        public int id = 0;

        public void PostJob()
        {
            Job newJob = new Job();
            Console.WriteLine("Enter Job Title");
            newJob.Title = Console.ReadLine();
            Console.WriteLine("Enter Job Title");
            newJob.ExperienceLevel = Console.ReadLine();
            Console.WriteLine("Enter Job Title");
            newJob.Company = Console.ReadLine();
            Console.WriteLine("Enter Job Title");
            newJob.Location = Console.ReadLine();
            Console.WriteLine("Enter Job Title");
            newJob.SalaryRange = Console.ReadLine();
            Console.WriteLine("Enter Job Title");
            newJob.JobType = Console.ReadLine();

            post[jobCount] = newJob;
            jobCount++;

            Console.WriteLine("Job Posted Successfull");
        }

        public void ListJob()
        {
            for (int i = 0; i < jobCount; i++)
            {
                Console.WriteLine($"Title : {post[i].Title}");
                Console.WriteLine($"Title : {post[i].ExperienceLevel}");
                Console.WriteLine($"Title : {post[i].Company}");
                Console.WriteLine($"Title : {post[i].Title}");
                Console.WriteLine($"Title : {post[i].Title}");
                Console.WriteLine($"Title : {post[i].Title}");
                Console.WriteLine($"Title : {post[i].Title}");
            }
        }
        public void GetJobById()
        {
            Console.WriteLine("Enter the id of post you want");
            int a = Convert.ToInt32( Console.ReadLine() );

            bool jobFound = false;

            for(int i = 0;i < jobCount; i++)
            {
                if (post[i].Id == a)
                {
                    Console.WriteLine($"Job Found :"); 
                    Console.WriteLine($"Title : {post[i].Title}");
                    Console.WriteLine($"Experiance Level : {post[i].Company}");
                    Console.WriteLine($"Location : {post[i].Location}");
                    Console.WriteLine($"Salary Range : {post[i].Location}");
                    Console.WriteLine($"Job Type : {post[i].JobType}");
                    jobFound = true;
                    break;
                }
            }
            if (!jobFound)
            {
                Console.WriteLine("Job Not Found ");
            }
        }

        
        
    }
}
