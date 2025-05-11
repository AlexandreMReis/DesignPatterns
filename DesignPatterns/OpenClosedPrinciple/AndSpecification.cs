namespace DesignPatterns.OpenClosedPrinciple
{
    internal class AndSpecification : ISpecification<Product>
    {
        public IEnumerable<ISpecification<Product>> Specifications { get; set; }

        public AndSpecification(IEnumerable<ISpecification<Product>> specifications)
        {
            Specifications = specifications;
        }

        public bool Satisfies(Product product)
        {
            return Specifications.All(s => s.Satisfies(product));
        }
    }
}
