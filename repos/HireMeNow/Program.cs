using HireMeNow.Manager;
using System.Security.Cryptography.X509Certificates;

namespace HireMeNow
{
    class HireMeNow
    {

        static void Main(string[] args)
        {
            JobSeekerManager jobSeekerManager = new JobSeekerManager();

            Console.WriteLine("1.Registration");
            Console.WriteLine("2. Login");


            Console.WriteLine("Choose option");
            string select = Console.ReadLine();

            do
            {
                switch (select)
                {
                    case "1":
                        jobSeekerManager.RegisterSeeker();
                        break;
                    case "2":
                        jobSeekerManager.Login();
                        break;
                }
            } while ();
            
            
        }
        
    }
}
