using System;

namespace ISP.After
{
    /// <summary>
    /// Implements all methods of interface
    /// </summary>
	public class WorkCentre : IFax, IPrint, IScan
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