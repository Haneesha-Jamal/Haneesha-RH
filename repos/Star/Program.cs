using System.Collections;

namespace Star
{
    class Star
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");
            //int a = Convert.ToInt32(Console.ReadLine());

            ////for (int i = 1; i < a; ++i)
            ////{
            ////    for (int j = 1; j <= i; j++)
            ////    {
            ////        Console.WriteLine("");
            ////    }
            ////    Console.WriteLine("");
            ////}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(a + "*" + i + "=" + i * a);
            //}


            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i<= a; i++)
            //{
            //    for(int j = 1; j <= a; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            
            //for(int i =1; i<=a; i++)
            //{
            //    for(int j = 1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            for(int i = a; i >= 1; i--)
            {
                for(int j = 1; j <= 2*i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            
        }
    }
}

