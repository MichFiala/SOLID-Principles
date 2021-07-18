namespace LSP.Before
{
    /// <summary>
	/// State before applying principle
    /// We need to call ApplyExtraDiscount before getting discount   
	/// </summary>
    public class InHouseProduct : Product
    {
        public void ApplyExtraDiscount()
        {
			Discount *= 1.5;
		}
    }
}