using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
    public abstract class CompositeBinarySpecification<T> : ISpecification<T> 
    {
        protected ISpecification<T> Right { get; private set; }
        protected ISpecification<T> Left { get; private set; }
        public CompositeBinarySpecification(ISpecification<T> rightSpecification, ISpecification<T> leftSpecification)
        {
            Right = rightSpecification;
            Left = leftSpecification;
        }
        public abstract bool IsSatisfiedBy(T value);
    }

}
