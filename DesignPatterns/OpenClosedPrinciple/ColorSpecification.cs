namespace DesignPatterns.OpenClosedPrinciple
{
    public class ColorSpecification : ISpecification<Product>
    {
        public Color Color { get; }
        public ColorSpecification(Color color)
        {
            Color = color;
        }

        public bool Satisfies(Product item)
        {
            return item.Color == Color;
        }
    }
}
