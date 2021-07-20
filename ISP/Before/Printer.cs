using System;

namespace ISP.Before
{
    /// <summary>
    /// Implements only Print method, others blank
    /// </summary>
	public class Printer : IMultiFunction
	{
		public void Fax()
		{
			
		}

		public void Print()
		{
			Console.WriteLine("Printed");
		}

		public void Scan()
		{
			
		}
	}
}