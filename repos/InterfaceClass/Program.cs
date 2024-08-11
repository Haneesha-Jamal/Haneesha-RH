namespace InterfaceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape cir = new Circle(6);
            IShape rec = new Rectangle(3, 5);

            Console.WriteLine("circle Area: " +cir.Area());
            Console.WriteLine("circle perimeter :"+cir.Perimeter());

            Console.WriteLine("Reactangle Area: " + rec.Area());
            Console.WriteLine("Reactanle perimeter :" + rec.Perimeter());



        }
    }
}
