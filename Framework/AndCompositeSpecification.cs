using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
    public class AndCompositeSpecification<T> : CompositeBinarySpecification<T>
    {
        public AndCompositeSpecification(ISpecification<T> rightSpecification, ISpecification<T> leftSpecification):base (rightSpecification, leftSpecification)
        {
        }
        public override bool IsSatisfiedBy(T value)
        {
            return Right.IsSatisfiedBy(value) && Left.IsSatisfiedBy(value);
        }
    }
}
