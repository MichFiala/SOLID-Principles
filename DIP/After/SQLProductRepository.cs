using System.Collections.Generic;

namespace DIP.After
{
    public class SQLProductRepository : IProductRepository
    {
        public List<string> GetAllProductNames()
        {
			return new List<string>() { "product1", "product2" };
		}
    }
}