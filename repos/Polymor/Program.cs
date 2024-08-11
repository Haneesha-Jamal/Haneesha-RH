namespace Polymor
{
    class Program
    {
        static void Main(string[] args) 
        {
            //method overloading
            Calculator calc = new Calculator();
            int sum1 = calc.Add(5, 5);
            Console.WriteLine("sum1 is" +sum1);
            double sum2 = calc.Add(5.4, 5.3);
            Console.WriteLine("sum2 is" + sum2);
        }

    }
}
