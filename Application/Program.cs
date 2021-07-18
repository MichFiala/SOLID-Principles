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
            
			Console.ReadLine();
        }
    }
}
