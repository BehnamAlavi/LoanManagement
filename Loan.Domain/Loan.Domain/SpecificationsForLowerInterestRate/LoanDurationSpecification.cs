using Framework;

namespace Loan.Domain.SpecificationsForLowerInterestRate
{
    public class LoanDurationSpecification: ISpecification<LoanReceiving>
    {
        public bool IsSatisfiedBy(LoanReceiving item)
        {
            return item.Duration < 10;
        }
    }
}
