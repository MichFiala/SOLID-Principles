using System;

namespace SRP.After
{
    /// <summary>
    /// State after applying principle
    /// Reasons to change:s
    ///     1 - Change in database     
    /// </summary>
    public class EmployeeRepository
    {
        public void Save(Employee employee)
        {
			string objectString = String.Format("{0}-{1}-{2}",employee.Id, employee.Name, employee.Address);

            try{
				// Do save action into database
				Console.WriteLine("Saved: " + objectString);
			}
            catch(Exception ex)
            {
				Console.WriteLine(ex);
			}
		}
    }
}