namespace DesignPatterns.OpenClosedPrinciple
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color) => products.Where(p => p.Color == color);
    }
}
