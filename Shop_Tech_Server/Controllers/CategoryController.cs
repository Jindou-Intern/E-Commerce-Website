using Microsoft.AspNetCore.Mvc;
using Shop_Tech_Server.Repsitories;
using Shop_Tech_Shared_Library.Models;
using Shop_Tech_Shared_Library.Responses;

namespace Shop_Tech_Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController(ICategory categoryService) : ControllerBase
	{
        [HttpGet]
		public async Task<ActionResult<List<Product>>>GetAllProducts()
		{
			var categories = await categoryService.GetAllCategories();
			return Ok(categories);
		}
		[HttpPost]
		public async Task<ActionResult<ServiceResponse>> AddCategory(Category model)
		{
			if (model is null) return BadRequest("Model is Null");
			var response = await categoryService.AddCategory(model);
			return Ok(response);
		}
	}
}
