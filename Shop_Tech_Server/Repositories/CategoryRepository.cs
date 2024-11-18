using Microsoft.EntityFrameworkCore;
using Shop_Tech_Server.Data;
using Shop_Tech_Server.Repsitories;
using Shop_Tech_Shared_Library.Models;
using Shop_Tech_Shared_Library.Responses;

namespace Shop_Tech_Server.Repositories
{
	public class CategoryRepository(AppDbContext appDbContext) : ICategory
	{
		private readonly AppDbContext appDbContext = appDbContext;

        public async Task<ServiceResponse> AddCategory(Category model)
		{
			if (model is null) return new ServiceResponse(false, "Model is null");

			var (flag, message) = await CheckName(model.Name!);

			if(flag)
			{
				appDbContext.Categories.Add(model);
				await Commit();
				return new ServiceResponse(true, "Category Saved");
			}
			return new ServiceResponse(flag, message);
		}

		public async Task<List<Category>> GetAllCategories() => await appDbContext.Categories.ToListAsync();

        private async Task<ServiceResponse> CheckName(string name)
		{
			var category = await appDbContext.Categories
				.FirstOrDefaultAsync(x => x.Name!.ToLower()!.Equals(name.ToLower()));
			return category is null ? new ServiceResponse(true, null!) : new ServiceResponse(false, "Category already exist");
		}
		private async Task Commit() => await appDbContext.SaveChangesAsync();
	}
}
