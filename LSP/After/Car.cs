namespace LSP.After
{
    public class Car : Vehicle
    {
        public override double InteriorWidth => CabinWidth;
		
        public double CabinWidth { get; set; }
    }
}