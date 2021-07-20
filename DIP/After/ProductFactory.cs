namespace DIP.After
{
    public class ProductFactory
    {
        public static IProductRepository Create()
        {
			return new SQLProductRepository();
		}
    }
}