namespace Loan.Domain.SpecificationsForLowerInterestRate
{
    public interface IOperation<T> where T : LoanReceiving
    {
        ILoanCriteria<T> ApplyCriteria();
    }
}