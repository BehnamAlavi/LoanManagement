using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
    public class ORCompositeSpecification<T> : CompositeBinarySpecification<T>
    {
        public ORCompositeSpecification(ISpecification<T> rightSpecification, ISpecification<T> leftSpecification):base(rightSpecification, leftSpecification)
        {
        }
        public override bool IsSatisfiedBy(T value)
        {
            return Right.IsSatisfiedBy(value) || Left.IsSatisfiedBy(value);
        }
    }
}
