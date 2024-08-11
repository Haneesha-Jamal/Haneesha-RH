namespace Problem
{
    class Problem
    {

        struct cred
        {
            public string fullName;
            public string email;
            public string password;
            public string birthday;
            public string location;

        }
        static cred[] datas = new cred[10];
        static int UserCount = 0;
        static bool isLoggedIn = false;

        public static void Main(string[] args)
        {
            
            string choose;

            do
            {

                Console.WriteLine("****************************************");
                Console.WriteLine("1.Registration");
                Console.WriteLine("2.Login");
                Console.WriteLine("3.Exit");
                Console.WriteLine("****************************************");

                string? select = Console.ReadLine();
               
                switch (select)
                    
                {
                    case "1":
                        {
                            Console.WriteLine("Welcome to Hilton");
                            Console.WriteLine("Register here for dellisious Dishes");
                            Register();
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine("login with your Details");
                            Login();
                        }
                        break;

                    case "3":
                        {
                            Console.WriteLine("Bye come back soon");
                            Exit();

                        }
                        break;
                }
                Console.WriteLine("Do you want to continue y/Y");
                choose = Console.ReadLine();

            } while (choose == "y" || choose == "Y");

            
            
        }

         static void Register()
        {
            cred data = new cred();

            Console.WriteLine("your full name : ");
            data.fullName = Console.ReadLine();

            Console.WriteLine("your email : ");
            data.email = Console.ReadLine();

            Console.WriteLine("your password : ");
            data.password = Console.ReadLine();

            Console.WriteLine("your birth date : ");
            data.birthday = Console.ReadLine();

            Console.WriteLine("your location : ");
            data.location = Console.ReadLine();

            Console.WriteLine("Registration successfull");
            Console.WriteLine("order your fav");

            datas[UserCount] = data;
            UserCount++;
        }

        static void Login()
        {
            Console.WriteLine("****************************************");

            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();  

            Console.WriteLine("password :");
            string password = Console.ReadLine();

            bool loginSuccessfull = false;

            foreach (cred i in datas)
            {
                if(i.email == email && i.password == password)
                {
                    loginSuccessfull = true;
                    isLoggedIn = true;

                    Console.WriteLine("Login successfull");
                    Console.WriteLine("Account details : ");
                }
                
                
            }

        }

        static void Exit()
        {
            isLoggedIn = false;
            Console.WriteLine("Logged out successfully");
        }
    }
}
