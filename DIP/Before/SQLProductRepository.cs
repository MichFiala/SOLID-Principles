using System.Collections.Generic;

namespace DIP.Before
{
    public class SQLProductRepository
    {
        public List<string> GetAllProductNames()
        {
			return new List<string>() { "product1", "product2" };
		}
    }
}