namespace LSP.Before
{
    public class Car
    {
        public virtual double CabinWidth { get; }

        public Car(double cabinWidth = 0)
        {
			CabinWidth = cabinWidth;
		}
    }
}