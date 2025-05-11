namespace DesignPatterns.OpenClosedPrinciple
{
    public class BetterFilter
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> specification)
        {
            return products.Where(p => specification.Satisfies(p));
        }
    }
}
