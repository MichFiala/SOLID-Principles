using System;

namespace ISP.Before
{
    /// <summary>
    /// Implements all methods of interface
    /// </summary>
	public class WorkCentre : IMultiFunction
	{
		public void Fax()
		{
			Console.WriteLine("Faxed");
		}

		public void Print()
		{
			Console.WriteLine("Printed");
		}

		public void Scan()
		{
			Console.WriteLine("Scaned");
		}
	}
}