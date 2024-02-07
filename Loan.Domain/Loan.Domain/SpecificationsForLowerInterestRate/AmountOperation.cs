namespace Loan.Domain.SpecificationsForLowerInterestRate
{
    public class AmountOperation : IOperation<LoanReceiving>
    {
        private readonly LoanReceiving _loanReceiving;
        public ILoanCriteria<LoanReceiving> LoanCriteria { get; set; }
        internal AmountOperation(LoanReceiving loanReceiving)
        {
            _loanReceiving = loanReceiving;
           
        }
        public ILoanCriteria<LoanReceiving> ApplyCriteria()
        {
            LoanCriteria.Result = this.IsSatisfiedBy(_loanReceiving);
            return LoanCriteria;
        }

        public bool IsSatisfiedBy(LoanReceiving item)
        {
            return item.Amount > 0 && item.Amount < 10;
        }
    }
}