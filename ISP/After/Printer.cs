using System;

namespace ISP.After
{
    /// <summary>
    /// Implements only Print method, without any blank method
    /// </summary>
	public class Printer : IPrint
	{
		public void Print()
		{
			Console.WriteLine("Printed");
		}
	}
}