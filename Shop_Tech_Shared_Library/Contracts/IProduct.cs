using Shop_Tech_Shared_Library.Models;
using Shop_Tech_Shared_Library.Responses;

namespace Shop_Tech_Shared_Library.Contracts
{
	public  interface IProduct
	{
		Task<ServiceResponse> AddProduct(Product model);
		Task<List<Product>> GetAllProducts(bool featuredProducts);
	}
}
