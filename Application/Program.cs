using System;
using System.Collections.Generic;

namespace Application
{
	class Program
	{
		static void SRPExample()
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
		}

		static void OCPExample()
		{
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
		}


		static void LSPExample()
		{
			// LSP - before
			LSP.Before.Product product1 = new LSP.Before.Product { Discount = 20 };
			LSP.Before.Product product2 = new LSP.Before.Product { Discount = 30 };
			LSP.Before.Product product3 = new LSP.Before.InHouseProduct { Discount = 30 };

			List<LSP.Before.Product> listOfProducts = new List<LSP.Before.Product>()
			{
				product1, product2, product3
			};

			foreach(var product in listOfProducts)
			{
				// We need to check type and execute aplication of extra discount
				if(product.GetType() == typeof(LSP.Before.InHouseProduct)) ((LSP.Before.InHouseProduct)product).ApplyExtraDiscount();

				Console.WriteLine(product.Discount);
			}
			Console.WriteLine();
			// LSP - after - Tell, Don't ask
			LSP.After.Product product1After = new LSP.After.Product { Discount = 20 };
			LSP.After.Product product2After = new LSP.After.Product { Discount = 30 };
			LSP.After.Product product3After = new LSP.After.InHouseProduct { Discount = 30 };

			List<LSP.After.Product> listOfProductsAfter = new List<LSP.After.Product>()
			{
				product1After, product2After, product3After
			};

			foreach(var product in listOfProductsAfter)
			{
				// We DO NOT need to check type and execute aplication of extra discount
				Console.WriteLine(product.Discount);
			}
			Console.WriteLine();
			// LSP - before
			LSP.Before.Car car1 = new LSP.Before.Car (100);
			LSP.Before.Car car2 = new LSP.Before.Car (200);
			LSP.Before.Car car3 = new LSP.Before.RacingCar (300);

			List<LSP.Before.Car> cars = new List<LSP.Before.Car>()
			{
				car1, car2, car3
			};

			foreach(var car in cars)
			{
				try
				{
					// Throws exception on Racing car instance
					Console.WriteLine(car.CabinWidth);
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
			Console.WriteLine();
			// LSP - after - break the hierarchy
			LSP.After.Vehicle car1After = new LSP.After.Car { CabinWidth = 100 };
			LSP.After.Vehicle car2After = new LSP.After.Car { CabinWidth = 200 };
			LSP.After.Vehicle car3After = new LSP.After.RacingCar { CockpitWidth = 300 };

			List<LSP.After.Vehicle> vehiclesAfter = new List<LSP.After.Vehicle>()
			{
				car1After, car2After, car3After
			};

			foreach(var vehicle in vehiclesAfter)
			{
				// Works fine for all vehicle instances
				Console.WriteLine(vehicle.InteriorWidth);
			}
		}

		static void ISPExample()
		{
			// ISP - before
			ISP.Before.IMultiFunction workCentre = new ISP.Before.WorkCentre();
			ISP.Before.IMultiFunction printer = new ISP.Before.Printer();
			ISP.Before.IMultiFunction scanner = new ISP.Before.Scanner();

			List<ISP.Before.IMultiFunction> devices = new List<ISP.Before.IMultiFunction>()
			{
				workCentre, printer, scanner
			};
			// It looks like printer can scan, scanner can print etc..
			foreach(var device in devices)
			{
				device.Fax();
				device.Print();
				device.Scan();
			}
			// ISP - after
			// -> Work centre can do whatever interfaces we use
			// -> Printer can only print
			// -> Scanner can only scan
			ISP.After.IFax workCentreAfter = new ISP.After.WorkCentre();
			ISP.After.IPrint printerAfter = new ISP.After.Printer();
			ISP.After.IScan scannerAfter = new ISP.After.Scanner();

			// 1) We are getting from Liskov substituion principle as well
			// We can replace IFax only with class implementing IFax and it would work still the same without error
			// We can replace IPrint only with class implementing IPrint and it would work still the same without error
			// 2) Our interfaces are now following SRP 

		}
		static void Main(string[] args)
		{
			SRPExample();

			OCPExample();

			LSPExample();

			Console.ReadLine();
		}
	}
}
