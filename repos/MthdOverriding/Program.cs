namespace MthdOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Rectangle rect = new Rectangle();
            rect.Draw();
            circle.Draw();
            Shape shape1 = new Shape();
            Shape shape2 = new Shape();
            shape1.Draw();
            shape2.Draw();
        }
    }
}
