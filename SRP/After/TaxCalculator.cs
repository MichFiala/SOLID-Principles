namespace SRP.After
{
    /// <summary>
    /// State after applying principle
    /// Reasons to change:
    ///     1 - Change in tax calculation     
    /// </summary>
    public class TaxCalculator
    {
        public void CalculateTax(Employee employee)
        {
            if(employee.Type.Equals("fulltime"))
            {
                // Tax calc for full time
            }
            if(employee.Type.Equals("contract"))
            {
                // Tax calc for contract
            }
        }
    }
}