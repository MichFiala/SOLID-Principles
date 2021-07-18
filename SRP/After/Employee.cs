using System;

namespace SRP.After
{
    /// <summary>
    /// State after applying principle
    /// Reasons to change:
    ///     1 - Change of employee attributes 
    /// </summary>
    public class Employee
    {
        public int Id{ get; set; }

        public string Name { get; set; }

        public string  Address { get; set; }

        public string Type { get; set; }

        public void Save()
        {
			new EmployeeRepository().Save(this);
		}

        public void CalculateTax()
        {
			new TaxCalculator().CalculateTax(this);
		}
	}
}