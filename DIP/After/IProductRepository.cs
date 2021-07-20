using System.Collections.Generic;

namespace DIP.After
{
    public interface IProductRepository
    {
		List<string> GetAllProductNames();
	}
}