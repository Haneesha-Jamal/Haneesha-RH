namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle("red",5);
            Rectangle rec = new Rectangle(6, 6,"blue");
            Console.WriteLine(cir.Area());
            Console.WriteLine(rec.Area());

            cir.DisplayColor("red");
            rec.DisplayColor("blue");

        }
    }
}
