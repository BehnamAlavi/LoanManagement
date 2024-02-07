using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Domain.SpecificationsForLowerInterestRate
{
    public class LoanCriteria : ILoanCriteria<LoanReceiving>
    {

        private readonly LoanReceiving _loanReceiving;  
        private readonly IOperation<LoanReceiving> _operation1;
        private readonly IOperation<LoanReceiving> _operation2;
        public LoanCriteria(LoanReceiving loanReceiving):this(new AmountOperation(loanReceiving), new DurationOperation(loanReceiving))
        {
            _loanReceiving = loanReceiving;
        }
        internal LoanCriteria(IOperation<LoanReceiving> operation1, IOperation<LoanReceiving> operation2) 
        {
            _operation1 = operation1;
            _operation2 = operation2;
            (_operation1 as AmountOperation).LoanCriteria = this;
            (_operation2 as DurationOperation).LoanCriteria = this;
        }

        public bool Result { get; set; }

        public IOperation<LoanReceiving> CheckAmount()
        {

            return _operation1;
        }

        public IOperation<LoanReceiving> CheckDuration()
        {
            return _operation2;
        }
    }
}
