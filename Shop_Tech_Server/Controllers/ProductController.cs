using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop_Tech_Server.Repsitories;
using Shop_Tech_Shared_Library.Models;
using Shop_Tech_Shared_Library.Responses;

namespace Shop_Tech_Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController(IProduct productService) : ControllerBase
	{
		private readonly IProduct productService = productService;

        [HttpGet]
		public async Task<ActionResult<List<Product>>>GetAllProducts(bool featured)
		{
			var products = await productService.GetAllProducts(featured);
			return Ok(products);
		}
		[HttpPost]
		public async Task<ActionResult<ServiceResponse>>AddProduct(Product model)
		{
			if (model is null) return BadRequest("Model is Null");
			var response = await productService.AddProduct(model);
			return Ok(response);
		}
	}
}
