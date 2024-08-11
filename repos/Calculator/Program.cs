using System.ComponentModel;

namespace Calculator
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            bool endApp = false;

            while (!endApp)
            {
                string num1 = "";
                string num2 = "";
                double result = 0;

                Console.WriteLine("Enter one number you want to calculate");
                 num1 = Console.ReadLine();

                Console.WriteLine("Enter another number");
                num2 = Console.ReadLine();

                Console.WriteLine("Choose an option for your need");

                Console.WriteLine();
                Console.WriteLine("a) Add");
                Console.WriteLine("s) Substract");
                Console.WriteLine("m) Multiply");
                Console.WriteLine("d) Division");
                Console.WriteLine("q) Quit");

                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "a":
                        result = Add(num1, num2);
                        break;
                    case "s":
                        result = Sub(num1, num2);
                        break;
                    case "m":
                        result = Mul(num1, num2);
                        break;
                    case "d":
                        result = Div(num1, num2);
                        break;
                    case "q":
                        endApp = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                if(endApp == false)
                {
                    Console.WriteLine($"The result is : {result}");
                }
            }
        }

         public static double Add(string num1 , string num2)
        {
            double one = Convert.ToDouble(num1);
            double two = Convert.ToDouble(num2);
            double result = one + two;
            return result;
        }
        
        public static double Sub(string num1, string num2)
        {
            double one = Convert.ToDouble(num1);
            double two = Convert.ToDouble(num2);
            double result = one - two;
            return result;
        }

        public static double Mul(string num1, string num2)
        {
            double one = Convert.ToDouble(num1);
            double two = Convert.ToDouble(num2);
            double result = one * two;
            return result;
        }

        public static double Div(string num1, string num2)
        {
            double one = Convert.ToDouble(num1);
            double two = Convert.ToDouble(num2);
            double result = one / two;
            return result;
        }
    }
}
