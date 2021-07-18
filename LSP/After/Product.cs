namespace LSP.After
{
    public class Product
    {
		protected double _discount;
		public virtual double Discount 
        {
			get => _discount;
			set => _discount = value;
		}
    }
}