using HireMeNow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace HireMeNow.Manager
{
    public class JobSeekerManager
    {
        public JobSeekerManager() { }

        public Job[] post = new Job[5];
        public int jobCount = 0;
        public int id = 0;

        public JobSeeker[] JobSeek = new JobSeeker[5];
        int SeekerCount = 0;

        public JobSeeker  loggedInSeeker = new JobSeeker();
        public void RegisterSeeker()
        {
            JobSeeker newSeeker = new JobSeeker();

            Console.WriteLine("Enter your First name");
            newSeeker.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Lasst name");
            newSeeker.LastName = Console.ReadLine();

            Console.WriteLine("Enter your Email");
            newSeeker.Email = Console.ReadLine();

            Console.WriteLine("Enter your phone number");
            newSeeker.Phone = Console.ReadLine();

            Console.WriteLine("Enter your Location");
            newSeeker.Location = Console.ReadLine();

            Console.WriteLine("About You");
            newSeeker.AboutMe = Console.ReadLine();

            Console.WriteLine("Enter your Qualification");
            newSeeker.Qualification = Console.ReadLine();

            Console.WriteLine("Enter your experiance");
            newSeeker.ExperianceLevel = Console.ReadLine();

            Console.WriteLine("Enter password");
            newSeeker.Password = Console.ReadLine();

            JobSeek[SeekerCount] = newSeeker;
            SeekerCount++;

            Console.WriteLine("Registration Successfull");
        }

        public bool Login()
        {
            Console.WriteLine("Enter Email : ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Email : ");
            string password = Console.ReadLine();

            bool loginSuccess = false;

            foreach(JobSeeker seeker in JobSeek)
            {
                if( email == seeker.Email && password == seeker.Password)
                {
                    loggedInSeeker = seeker;
                    loginSuccess = true;
                    ShowJobSeekerMenu();
                    break;
                }
            }
            return loginSuccess;

        }

        public void ShowJobSeekerMenu()
        {
            Console.WriteLine("1.Apply Job");
            Console.WriteLine("2.Save Job");
            Console.WriteLine("3.View Profile");
            Console.WriteLine("4.Logout");
            Console.WriteLine("5.Show Main Menu");

            Console.WriteLine("Choose any option!");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                      ApplyJob();
                      break;
                case "2":
                     SaveJob();
                      break;
                case "3":
                    ViewProfile();
                      break;
                case "4":
                    Logout();
                      break;
                case "5":
                    ShowMain();
                      break;  
            }
        }

        public void ApplyJob()
        {
            Job job = new Job();
            Console.WriteLine("Enter the id of post you want");
            int a = Convert.ToInt32(Console.ReadLine());

            bool jobFound = false;

            for (int i = 0; i < jobCount; i++)
            {
                if (post[i].Id == a)
                {

                    jobFound = true;
                    break;
                }
            }
        }
        public void SaveJob()
        {

        }
        public void ViewProfile()
        {

        }
        public void Logout()
        {

        }
        public void ShowMain()
        {

        }
    }
}
