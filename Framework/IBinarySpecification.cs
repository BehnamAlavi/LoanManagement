namespace Framework
{
    public interface IBinarySpecification<T> :ISpecification<T>
    {

        void SetT(T value);

        IBinarySpecification<T> Left(IBinarySpecification<T> specification);

        IBinarySpecification<T> Right(IBinarySpecification<T> specification);
        bool IsSatisfiedBy(T item);

        bool ApplyRules();

    }
}
