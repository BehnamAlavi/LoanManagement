using Framework;

namespace Loan.Domain.SpecificationsForLowerInterestRate
{
    public class CustomerWorkExperienceSpecification : ISpecification<LoanReceiving>
    {
        public bool IsSatisfiedBy(LoanReceiving item)
        {
            return item.PreviousWorkExperience >= 15;
        }
    }
}
