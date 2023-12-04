using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Domain.SpecificationsForLowerInterestRate
{
    public class QualifiesForLowerInterestSpecification : CompositeBinarySpecification<LoanReceiving>
    {
        public QualifiesForLowerInterestSpecification(ISpecification<LoanReceiving> rightSpecification, ISpecification<LoanReceiving> leftSpecification) :
            base(rightSpecification, leftSpecification)
        {
        }

        public override bool IsSatisfiedBy(LoanReceiving value)
        {
            return Right.IsSatisfiedBy(value) && Left.IsSatisfiedBy(value);
        }
    }
}
