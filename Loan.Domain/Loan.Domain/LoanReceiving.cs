using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Domain
{
    public class LoanReceiving
    {
        public decimal Amount { get; set; }

        public int Duration { get; set; }

        //FK to possibly LoanReceiverRate Entity/Aggregate:TODO: subject to later design
        public int LoanReceiverRate { get; set; }

        //FK to PreviousWorkExperience Entity/Aggregate:TODO: subject to later design
        public int PreviousWorkExperience { get; set; }
    }
}
