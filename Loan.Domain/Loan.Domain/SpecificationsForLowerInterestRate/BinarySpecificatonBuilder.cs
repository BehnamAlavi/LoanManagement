using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.Domain.SpecificationsForLowerInterestRate
{
    public class BinarySpecificatonBuilder : IBinarySpecification<LoanReceiving>
    {
       
        private readonly List<ISpecification<LoanReceiving>> _loanReceivingSpecs;
        
        public BinarySpecificatonBuilder()
        {
            _loanReceivingSpecs = new List<ISpecification<LoanReceiving>>();
        }

        public bool ApplyRules()
        {
            bool result = false;
           
            _loanReceivingSpecs.ForEach(spec => {

               if(spec is IBinarySpecification<LoanReceiving>) 
                {
                    result = ((IBinarySpecification<LoanReceiving>)spec).ApplyRules();
                }
                else
                {
                    result = ((IBinarySpecification<LoanReceiving>)spec).ApplyRules();
                }
}

            );

            return result;
        }

        public bool IsSatisfiedBy(LoanReceiving item)
        {
            // bool result = true;
            //var uniqueSpec = _loanReceivingSpecs.Aggregate<ISpecification<LoanReceiving>>((a, b) => {

            //    return a.Left(b);
            //});
            return false;
           
        }

        public IBinarySpecification<LoanReceiving> Left(IBinarySpecification<LoanReceiving> specification)
        {
            _loanReceivingSpecs.Add(specification);
            return this;
        }

        public IBinarySpecification<LoanReceiving> Right(IBinarySpecification<LoanReceiving> specification)
        {
            _loanReceivingSpecs.Add(specification);
            return this;
        }

        public void SetT(LoanReceiving value)
        {
            throw new NotImplementedException();
        }
    }
}
