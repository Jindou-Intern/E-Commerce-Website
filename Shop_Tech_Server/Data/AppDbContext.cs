using Microsoft.EntityFrameworkCore;
using Shop_Tech_Shared_Library.Models;

namespace Shop_Tech_Server.Data
{
	public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
	{
        public DbSet<Product> Products { get; set; } = default!;
		public DbSet<Category> Categories { get; set; } = default!;
		public DbSet<UserAccount> UserAccounts { get; set; } = default!;
		public DbSet<SystemRole> SystemRoles { get; set; } = default!;
		public DbSet<UserRole> UserRoles { get; set; } = default!;
		public DbSet<TokenInfo> TokenInfo { get; set; } = default!;
	}
}
