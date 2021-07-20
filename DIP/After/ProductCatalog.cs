namespace DIP.After
{
	public class ProductCatalog
	{
		private readonly IProductRepository _repository;
		/// <summary>
		/// Product catalog is dependend complete only on IProductRepository using Dependency Injection
		/// </summary>
		/// <param name="repository"></param>
		public ProductCatalog(IProductRepository repository)
		{
			_repository = repository;
		}
		public ProductCatalog()
		{
		}

		public void ListAllProducts()
		{
			// Product catalog is NOT directly depend on SQLProductRepository(Low level module)
			// It is depended on IProductRepository now
			// It is depended on Factory as well
			IProductRepository productRepository = ProductFactory.Create();
			productRepository.GetAllProductNames();
			// List all products here
		}

		public void ListAllProductsRepositoryInjected()
		{
			_repository.GetAllProductNames();
			// List all products here
		}
	}
}