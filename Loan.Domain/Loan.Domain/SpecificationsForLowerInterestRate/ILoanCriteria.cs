using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Domain.SpecificationsForLowerInterestRate
{
    public interface ILoanCriteria<T> where T: LoanReceiving
    {
        IOperation<T> CheckDuration();

        IOperation<T> CheckAmount();

        bool Result { get; set; }

    }
}
