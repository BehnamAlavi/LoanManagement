using Framework;


namespace Loan.Domain.SpecificationsForLowerInterestRate
{
    public class LoanAmountSpecification: ISpecification<LoanReceiving>
    {
        public bool IsSatisfiedBy(LoanReceiving item)
        {
            
            return item.Amount > 100000000;
        }
    }
}
