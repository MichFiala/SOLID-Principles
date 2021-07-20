namespace DIP.Before
{
    public class ProductCatalog
    {
        public void ListAllProducts()
        {
            // Product catalog is directly depend on SQLProductRepository(Low level module)
			SQLProductRepository sqlProductRepository = new SQLProductRepository();
			sqlProductRepository.GetAllProductNames();
            // List all products here
		}
    }
}