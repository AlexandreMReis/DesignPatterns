namespace DesignPatterns.OpenClosedPrinciple
{
    public interface ISpecification<T>
    {
        public bool Satisfies(T item);
    }
}
