namespace DesignPatterns.OpenClosedPrinciple
{
    public class Demo : IDemo
    {
        public void Execute()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            var products = new List<Product>() { apple, tree, house };

            var pf = new ProductFilter();
            Console.WriteLine("Green products (old):");
            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            var bf = new BetterFilter();
            Console.WriteLine("Green products (new):");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            Console.WriteLine("Green products (new):");
            var andSpecification = new AndSpecification(new List<ISpecification<Product>>()
            {
                new ColorSpecification(Color.Blue),
                new SizeSpecification(Size.Large)
            });
            foreach (var p in bf.Filter(products, andSpecification))
            {
                Console.WriteLine($" - {p.Name} is blue and large");
            }
        }
    }
}
