using System;

namespace ISP.After
{
    /// <summary>
    /// Implements only Scan method, without any blank method
    /// </summary>
	public class Scanner : IScan
	{
		public void Scan()
		{
			Console.WriteLine("Scanned");
		}
	}
}