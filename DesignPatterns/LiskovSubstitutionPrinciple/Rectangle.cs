namespace DesignPatterns.LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        public virtual int Width { get; set; }

        public virtual int Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
