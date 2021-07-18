using System;

namespace SRP.Before
{
	/// <summary>
	/// State before applying principle
	/// Reasons to change:
	///     1 - Change of employee attributes
	///     2 - Change in database 
	///     3 - Change in tax calculation     
	/// </summary>
	public class Employee
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Address { get; set; }

		public string Type { get; set; }

		public void Save()
		{
			string objectString = String.Format("{0}-{1}-{2}", Id, Name, Address); ;

			try
			{
				// Do save action into database
				Console.WriteLine("Saved: " + objectString);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		public void CalculateTax()
		{
			if (Type.Equals("fulltime"))
			{
				// Tax calc for full time
			}
			if (Type.Equals("contract"))
			{
				// Tax calc for contract
			}
		}
	}
}