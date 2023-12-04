using Loan.Domain;
using Loan.Domain.SpecificationsForLowerInterestRate;

namespace Domain_Criteria_Tests
{
    public class LoanReceivingTest1
    {
        [Fact]
        public void Check_IF_Loan_Receiver_Qualified_For_Discounted_Interest_Rate()
        {
            //Arrange
            LoanReceiving loanReceiving = new LoanReceiving() { Amount=10, Duration=20, LoanReceiverRate=10, PreviousWorkExperience=20 };

            //Act
            LoanAmountSpecification amountSpecification = new LoanAmountSpecification();
            LoanDurationSpecification durationSpecification = new LoanDurationSpecification();
            CustomerWorkExperienceSpecification customerWork = new CustomerWorkExperienceSpecification();

            QualifiesForLowerInterestSpecification qualifiesForLowerInterestSpecificationFirstTwo =
                new QualifiesForLowerInterestSpecification(amountSpecification, durationSpecification);

            QualifiesForLowerInterestSpecification qualifiesForLowerInterestSpecificationFinal =
               new QualifiesForLowerInterestSpecification(qualifiesForLowerInterestSpecificationFirstTwo, customerWork);

            bool result = qualifiesForLowerInterestSpecificationFinal.IsSatisfiedBy(loanReceiving);

            //Assert
            Assert.True(result);

        }
    }
}