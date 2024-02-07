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

        [Fact]
        public void Builder_Style_Check_IF_Loan_Duration_Satisfied()
        {
            //Arrange
            var specCriteria = new LoanCriteria(new LoanReceiving() { Duration=5 });

            //Act
            specCriteria.CheckDuration().ApplyCriteria();

            //Assert
            Assert.True(specCriteria.Result);
        }

        [Fact]
        public void Builder_Style_Check_IF_Loan_Duration_Amount_Satisfied()
        {
            //Arrange
            var specCriteria = new LoanCriteria(new LoanReceiving() { Duration = 5, Amount=5 });

            //Act
            specCriteria
                .CheckDuration()
                .ApplyCriteria()
                .CheckAmount()
                .ApplyCriteria();

            //Assert
            Assert.True(specCriteria.Result);
        }
    }
}