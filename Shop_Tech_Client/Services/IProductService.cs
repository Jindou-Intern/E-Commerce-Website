using Shop_Tech_Shared_Library.Models;
using Shop_Tech_Shared_Library.Responses;

namespace Shop_Tech_Client.Services
{
	public  interface IProductService
	{
		Action? ProductAction { get; set; }
		Task<ServiceResponse> AddProduct(Product model);
		Task GetAllProducts(bool featuredProducts);

		List<Product> AllProducts { get; set; }
		List<Product> FeaturedProducts { get; set; }
		List<Product> ProductsByCategory { get; set; }
		Task GetProductsByCategory(int categoryId);
		Product GetRandomProduct();
		bool IsVisible { get; set; }
    }
}
