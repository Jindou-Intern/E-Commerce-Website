using Shop_Tech_Shared_Library.Models;
using Shop_Tech_Shared_Library.Responses;

namespace Shop_Tech_Server.Repsitories
{
	public  interface ICategory
	{
		Task<ServiceResponse> AddCategory(Category model);
		Task<List<Category>> GetAllCategories();
	}
}
