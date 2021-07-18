namespace OCP.After
{
    /// <summary>
	/// State after applying principle
    /// If we add another customer profile, we DONT need to modifie calculator with overloaded method 
    /// We use interface for passing customer 
	/// </summary>
    public class InsurancePremiumDiscountCalculator
    {
        public int CalculateDiscountPercent(ICustomerProfile customer)
        {
            if(customer.IsLoyalCustomer) return 20;

			return 0;
		}
    }
}