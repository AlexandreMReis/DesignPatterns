namespace DesignPatterns.LiskovSubstitutionPrinciple
{
    public class Demo : IDemo
    {
        public void Execute()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;

            Rectangle square = new Square();
            square.Width = 5;
            square.Height = 10; // This will set both Width and Height to 10 violating Liskov Substitution Principle

            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
            Console.WriteLine("Square Area: " + square.CalculateArea());
        }
    }
}
