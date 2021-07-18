using System;

namespace LSP.Before
{
    /// <summary>
	/// State before applying principle
    /// Racing car does not have cabin width, calling get CabinWidth will cause exception   
	/// </summary>
    public class RacingCar : Car
    {
        public override double CabinWidth 
        {
			get { throw new NotImplementedException(); }
		}

        public double CockpitWidth { get; }
        public RacingCar(double cockpitWidth)
        {
			CockpitWidth = cockpitWidth;
		}
	}
}