using System;

namespace LSP.After
{
    /// <summary>
	/// State after applying principle
    /// We break the hierarchy in more generic way using vehicle class   
	/// </summary>
    public class RacingCar : Vehicle
    {
        public override double InteriorWidth => CockpitWidth;

        public double CockpitWidth { get; set; }
	}
}