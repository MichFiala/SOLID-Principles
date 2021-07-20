using System;

namespace ISP.Before
{
    /// <summary>
    /// Implements only Scan method, others blank
    /// </summary>
	public class Scanner : IMultiFunction
	{
		public void Fax()
		{
			
		}

		public void Print()
		{
			
		}

		public void Scan()
		{
			Console.WriteLine("Scanned");
		}
	}
}