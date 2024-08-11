using System.Runtime;

namespace Workshop4
{
    class Workshop4
    {
        struct AcDetails
        {
            public string Name;
            public string Age;
            public string Edu;
            public string Email;
            public string Password;
        }
        class Job
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Experience { get; set; }
            public string Company { get; set; }
            public string Location { get; set; }
            public string SalaryRange { get; set; }
        }

        static AcDetails[] Details = new AcDetails[5];
        static AcDetails loggedInUser;
        static bool isLoggedIn = false;
        static int UserCount = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("Welcome to job portal system");
            string yes;

            do
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("1. Registration");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Logout");
                Console.WriteLine("**************************************************\n");

                string select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        Register();
                        break;
                    case "2":
                        Login();
                        break;
                    case "3":
                        Logout();
                        break;
                }

                Console.WriteLine("Do you want to continue (y/Y");
                yes = Console.ReadLine();

            } while (yes == "y" || yes == "Y");
        }

        static void Register()
        {
            AcDetails newDetails = new AcDetails();

            Console.WriteLine("**************************************************");

            Console.WriteLine("Welcome Register here.....");

            Console.WriteLine("Enter your name :");
            newDetails.Name = Console.ReadLine();

            Console.WriteLine("Enter your Age :");
            newDetails.Age = Console.ReadLine();

            Console.WriteLine("Enter your Education :");
            newDetails.Edu = Console.ReadLine();

            Console.WriteLine("Enter your email :");
            newDetails.Email = Console.ReadLine();

            Console.WriteLine("Enter your password :");
            newDetails.Password = Console.ReadLine();

            Console.WriteLine("Registration successfull");
            Console.WriteLine("**************************************************");

            Details[UserCount] = newDetails;
            UserCount++;

        }

        static void Login()
        {
            string ch;

            Console.WriteLine("**************************************************");
            Console.WriteLine("Enter your Email");
            string? Email = Console.ReadLine();

            Console.WriteLine("Enter your Password");
            string? Password = Console.ReadLine();
            Console.WriteLine("**************************************************");

            bool logginSuccessfull = false;


            foreach (AcDetails i in Details)
            {

                if (i.Email == Email && i.Password == Password)
                {
                    logginSuccessfull = true;
                    isLoggedIn = true;
                    loggedInUser = i;

                    Console.WriteLine("Login successfull");
                    Console.WriteLine();
                    Console.WriteLine("Here is your Details");
                    Console.WriteLine("Name : {0} ", loggedInUser.Name);
                    Console.WriteLine("Age : {0} ", loggedInUser.Age);
                    Console.WriteLine("Edu : {0} ", loggedInUser.Edu);
                    Console.WriteLine("Email : {0} ", loggedInUser.Email);
                    Console.WriteLine("Password : {0} ", loggedInUser.Password);
                    Console.WriteLine();


                    if (logginSuccessfull)
                    {

                        Console.WriteLine("1. List all job");
                        Console.WriteLine("2. My Profile");

                        string choose = Console.ReadLine();
                        switch (choose)
                        {
                            case "1":
                                List();
                                break;
                            case "2":
                                Profile();
                                break;
                        }

                        static void List()
                        {
                            Console.WriteLine("**********************************************************");
                            Console.WriteLine("Here is the list of Available job.........");

                            List<Job> Avl = new List<Job>
                        {
                            new Job {Id = 1, Title = "Software Engineer", Experience = "2 years", Company= "Google"},
                            new Job {Id = 2, Title = "Developer", Experience = "5 years", Company= "Meta"},
                            new Job {Id = 3, Title = "UI/UX Designer", Experience = "7 years", Company= "Microsoft"},
                            new Job {Id = 4, Title = "Data scientist", Experience = "1 years", Company= "Nvidia"},
                            new Job {Id = 5, Title = "Quality Analyst", Experience = "9 years", Company= "Tcs"},
                        };
                            Console.WriteLine("Available job : ");
                            for (int i = 0; i < Avl.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {Avl[i].Title} - {Avl[i].Company} - {Avl[i].Location} - {Avl[i].SalaryRange}");
                            }
                        }
                        static void Profile()
                        {
                            Console.WriteLine("Name : {0} ", loggedInUser.Name);
                            Console.WriteLine("Age : {0} ", loggedInUser.Age);
                            Console.WriteLine("Edu : {0} ", loggedInUser.Edu);
                            Console.WriteLine("Email : {0} ", loggedInUser.Email);
                            Console.WriteLine("Password : {0} ", loggedInUser.Password);
                        }
                    }

                }
            }

            

        }
        static void Logout()
        {
            Console.WriteLine("Logged out");
            isLoggedIn = false;
        }
    }
}
