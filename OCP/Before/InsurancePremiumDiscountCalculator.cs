namespace OCP.Before
{
	/// <summary>
	/// State before applying principle
    /// If we add another customer profile, we need to modifie calculator with overloaded method    
	/// </summary>
    public class InsurancePremiumDiscountCalculator
    {
        public int CalculateDiscountPercent(HealthInsuranceCustomerProfile customer)
        {
            if(customer.IsLoyalCustomer) return 20;

			return 0;
		}

        public int CalculateDiscountPercent(VehicleInsuranceCustomerProfile customer)
        {
            if(customer.IsLoyalCustomer) return 20;

			return 0;
		}
    }
}