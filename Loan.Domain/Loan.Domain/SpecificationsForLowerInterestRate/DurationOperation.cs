using Framework;

namespace Loan.Domain.SpecificationsForLowerInterestRate
{
    public class DurationOperation : IOperation<LoanReceiving>, ISpecification<LoanReceiving>
    {
        private readonly LoanReceiving _loanReceiving;
        public ILoanCriteria<LoanReceiving> LoanCriteria { get; set; }
        internal DurationOperation(LoanReceiving loanReceiving) 
        {
            _loanReceiving = loanReceiving;
            //_loanCriteria = loanCriteria;   
        }
        public ILoanCriteria<LoanReceiving> ApplyCriteria()
        {
            LoanCriteria.Result = this.IsSatisfiedBy(_loanReceiving);
            return LoanCriteria;
        }

        public bool IsSatisfiedBy(LoanReceiving item)
        {
            return item.Duration > 0 && item.Duration < 10;
        }

        
    }
}