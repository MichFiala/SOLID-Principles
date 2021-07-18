namespace LSP.After
{
    /// <summary>
	/// State after applying principle
    /// We DO NOT need to call ApplyExtraDiscount before getting discount   
    /// Tell, Don't ask
	/// </summary>
    public class InHouseProduct : Product
    {
        public override double Discount 
        {
            get
            {
				ApplyExtraDiscount();
				return _discount;
			}
        }
        public void ApplyExtraDiscount()
        {
			_discount *= 1.5;
		}
    }
}