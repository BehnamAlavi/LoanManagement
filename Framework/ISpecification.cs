namespace Framework
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T item);

    }
}
