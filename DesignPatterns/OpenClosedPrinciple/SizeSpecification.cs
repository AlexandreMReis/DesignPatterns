namespace DesignPatterns.OpenClosedPrinciple
{
    public class SizeSpecification : ISpecification<Product>
    {
        public Size Size { get; }
        public SizeSpecification(Size size)
        {
            Size = size;
        }

        public bool Satisfies(Product item)
        {
            return item.Size == Size;
        }
    }
}
