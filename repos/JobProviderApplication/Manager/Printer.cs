using JobProviderApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace Managers
{
    public class Printer
    {
        public void Print(Job[] jobs)
        {

            foreach (var job in jobs)
            {
                Console.WriteLine($"Printing Job: ID - {job.ID}, Name - {job.Name}");
            }
        }

        public void Print(Application[] applications)
        {

            foreach (var application in applications)
            {
                Console.WriteLine($"Printing Application: ID - {application.ID}, Name - {application.Name}");
            }
        }

        public void Print(Interview[] interviews)
        {

            foreach (var interview in interviews)
            {
                Console.WriteLine($"Printing Interview: ID - {interview.ID}, Name - {interview.Name}");
            }
        }
    }

    public class Job
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Application
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Interview
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}