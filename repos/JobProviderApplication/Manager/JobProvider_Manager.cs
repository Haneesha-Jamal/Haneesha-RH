using JobProviderApplication.Interface;
using JobProviderApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProviderApplication.Manager
{
    public class JobProvider_Manager:IApplicationProvider,IInterviewProvider,IJobProvider
    {

        Job[] jb = new Job[20];
        Application[] Apply = new Application[50];
        Interview[] Intrw = new Interview[15];

        private int numJb = 0;
        private int numApp = 0;
        private int numIntrw = 0;

        int id = 0;
        ////////////////////Jobs////////////////////////////////
        public void PostJob()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You can add job here.....");

            Console.Write("Enter Job Title : ");
            string Title = Console.ReadLine();
            Console.Write("Enter Description : ");
            string Description = Console.ReadLine();
            Console.Write("Enter Salary : ");
            string Salary = Console.ReadLine();
            Console.Write("Enter Location : ");
            string Location = Console.ReadLine();
            Console.Write("Enter Type : ");
            string Type = Console.ReadLine();
            Console.Write("Enter Company : ");
            string Company = Console.ReadLine();

            Job newJob = new Job(id, Title, Description, Salary, Location, Type, Company);

            jb[numJb] = newJob;
            numJb++;

            Console.WriteLine("*******************************************************************");
        }

        public void GetJob()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("List job");
            Console.WriteLine("Job : ");

            for (int i = 0; i < numJb; i++)
            {
                Console.WriteLine($"id : {jb[i].Id}");
                Console.WriteLine($"Comapny : {jb[i].Title}");
                Console.WriteLine($"Post : {jb[i].Description}");
                Console.WriteLine($"Date : {jb[i].Salary}");
                Console.WriteLine($"Location : {jb[i].Location}");
                Console.WriteLine($"Time : {jb[i].Type}");
                Console.WriteLine($"Time : {jb[i].Company}");

            }
            Console.WriteLine("*******************************************************************");
        }
        ////////////////////Jobs//////////////////////////

        //////////////Job Application////////////////////
        public void AddApplication()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You Can Apply Here");
            
            Console.Write("Enter your Name : ");
            string Name = Console.ReadLine();
            Console.Write("Enter your Location : ");
            string Location = Console.ReadLine();
            Console.Write("Enter your Qualification : ");
            string Qualification = Console.ReadLine();
            Console.Write("Enter you experiance : ");
            string Experiance = Console.ReadLine();

            Application newApplication = new Application(id, Name, Location, Qualification, Experiance);

            Apply[numApp] = newApplication;
            numApp++;

            Console.WriteLine("*******************************************************************");
            return;

        }
        public void GetApplication()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Your Application:");
            for (int i = 0; i< numApp; i++)
            {
                Console.WriteLine($"id : {Apply[i].Id}");
                Console.WriteLine($"Name : {Apply[i].Name}");
                Console.WriteLine($"Location : {Apply[i].Location}");
                Console.WriteLine($"Qualification : {Apply[i].Qualification}");
                Console.WriteLine($"Experiance : {Apply[i].Experiance}");
            }
            Console.WriteLine("*******************************************************************");
        }

        /////////////job Application ///////////////////////////////
        
        ///////////interview/////////////////////////////
         public void ScheduleInterview()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Welcome The Interview section Add Interview.");
            
            Console.Write("Enter Company : ");
            string Company = Console.ReadLine();
            Console.Write("Enter Post : ");
            string Post = Console.ReadLine();
            Console.Write("Enter Date : ");
            string Date = Console.ReadLine();
            Console.Write("Enter Location : ");
            string Location = Console.ReadLine();
            Console.Write("Enter Time : ");
            string Time = Console.ReadLine();

            Interview newIntrw = new Interview(id, Company, Post,Date, Location,Time );

            Intrw[numIntrw] = newIntrw;
            numIntrw++;

            Console.WriteLine("Interview scheduled successfully");

            Console.WriteLine("*******************************************************************");
        }

        public void GetInterview()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Scheculed Interview");
            Console.WriteLine("Interviews : ");

            for (int i = 0; i<numIntrw; i++)
            {
                Console.WriteLine($"id : {Intrw[i].Id}");
                Console.WriteLine($"Comapny : {Intrw[i].Company}");
                Console.WriteLine($"Post : {Intrw[i].Post}");
                Console.WriteLine($"Date : {Intrw[i].Date}");
                Console.WriteLine($"Location : {Intrw[i].Location}");
                Console.WriteLine($"Time : {Intrw[i].Time}");
            }
            Console.WriteLine("*******************************************************************");
        }

        public void Print()
        {
            Print();
        }
        ///////////////interview////////////////////////////
    }
}

 