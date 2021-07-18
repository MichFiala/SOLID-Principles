using System;
using SRP;

namespace Application
{
	class Program
	{
		static void Main(string[] args)
		{
			// SRP - before
			SRP.Before.Employee employee = new SRP.Before.Employee
			{
				Id = 0,
				Name = "Clo",
				Address = "New york",
				Type = "fulltime"
			};

			employee.Save();
			// SRP - after
			SRP.After.Employee employeeAfter = new SRP.After.Employee
			{
				Id = 0,
				Name = "Clo",
				Address = "New york",
				Type = "fulltime"
			};

			employeeAfter.Save();
			// OCP - before
			OCP.Before.HealthInsuranceCustomerProfile customerHealth = new OCP.Before.HealthInsuranceCustomerProfile
			{
				IsLoyalCustomer = true
			};

			OCP.Before.VehicleInsuranceCustomerProfile customerVehicle = new OCP.Before.VehicleInsuranceCustomerProfile
			{
				IsLoyalCustomer = true
			};

			OCP.Before.InsurancePremiumDiscountCalculator premiumCalculator = new OCP.Before.InsurancePremiumDiscountCalculator();
			int discountHealthCustomer = premiumCalculator.CalculateDiscountPercent(customerHealth);
			int discountVehicleCustomer = premiumCalculator.CalculateDiscountPercent(customerVehicle);

			// OCP - after
			OCP.After.ICustomerProfile customerHealthAfter = new OCP.After.HealthInsuranceCustomerProfile
			{
				IsLoyalCustomer = true
			};

			OCP.After.ICustomerProfile customerVehicleAfter = new OCP.After.VehicleInsuranceCustomerProfile
			{
				IsLoyalCustomer = true
			};
			// We can add new type and DO NOT need to modifie calculator
			OCP.After.ICustomerProfile customerHomeAfter = new OCP.After.HomeInsuranceCustomerProfile
			{
				IsLoyalCustomer = true
			};
			OCP.After.InsurancePremiumDiscountCalculator premiumCalculatorAfter = new OCP.After.InsurancePremiumDiscountCalculator();
			int discountHealthCustomerAfter = premiumCalculatorAfter.CalculateDiscountPercent(customerHealthAfter);
			int discountVehicleCustomerAfter = premiumCalculatorAfter.CalculateDiscountPercent(customerVehicleAfter);
			int discountHomeCustomerAfter = premiumCalculatorAfter.CalculateDiscountPercent(customerHomeAfter);

			Console.ReadLine();
		}
	}
}
