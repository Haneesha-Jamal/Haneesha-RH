using System.Runtime;

namespace Login
{
    class Login
    {
        struct Details
        {
            public int Id;
            public string Name;
            public string Description;
            public string Email;
            public string Password;
            public string PhoneNumber;
        }

        static Details[] personal = new Details[5];
        static int UserCount;
        static bool isloggedIn = false;
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome..........");
                Console.WriteLine("***********************************************************");
                string choose;
                
            do
                {

                Console.WriteLine("***********************************************************");
                    Console.WriteLine("1.Registration");
                    Console.WriteLine("2.Login");
                    Console.WriteLine("3.Logout");
                Console.WriteLine("***********************************************************");

                string select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        Register();
                        break;
                    case "2":
                        login();
                        break;
                    case "3":
                        Logout();
                        break;
                }

                    Console.WriteLine("Do you want to Continue (y/Y");
                    choose = Console.ReadLine();
                } while (choose == "y" || choose == "Y");

            }

        static void Register()
        {
            Details person = new Details();
            Console.WriteLine("Register here...........");

            Console.WriteLine("Enter your name");
            person.Name = Console.ReadLine();

            Console.WriteLine("Enter your Description");
            person.Description = Console.ReadLine();

            Console.WriteLine("Enter your Email");
            person.Email = Console.ReadLine();

            Console.WriteLine("Enter your password");
            person.Password = Console.ReadLine();

            Console.WriteLine("Enter your mobile number");
            person.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Registration Successfull.........now you can login.");

            personal[UserCount] = person;
            UserCount++;

        }
        static void login()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Enter your Email");
            string? Email = Console.ReadLine();

            Console.WriteLine("Enter your Email");
            string? Password = Console.ReadLine();
            Console.WriteLine("***********************************************************");

            bool loginsuccessfull = false;

            foreach (Details i in personal)
            {
                if (i.Email == Email && i.Password == Password)
                {
                    loginsuccessfull = true;
                    isloggedIn = true;

                    Console.WriteLine("Login successfull");
                    Console.WriteLine("Here is your Acount Details");

                    Console.WriteLine("Name : {0}", i.Name);
                    Console.WriteLine("Description :{0}", i.Description);
                    Console.WriteLine("Email :{0}", i.Email);
                    Console.WriteLine("Password : {0}", i.Password);
                    Console.WriteLine("Phone Number : {0}", i.PhoneNumber);

                    Console.WriteLine("***********************************************************");
                    break;
                }
            }
            if (!loginsuccessfull)
            {
                Console.WriteLine("Invalid Details");
            }
        }
        static void Logout()
        {
                isloggedIn = false;
                Console.WriteLine("Your logging out.....");
        }
                
        }
    }

