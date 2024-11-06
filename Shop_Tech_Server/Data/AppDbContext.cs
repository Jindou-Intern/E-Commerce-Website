using Microsoft.EntityFrameworkCore;
using Shop_Tech_Shared_Library.Models;

namespace Shop_Tech_Server.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
		{ 
		}

		public DbSet<Product> Products { get; set; } = default!;
	}
}
