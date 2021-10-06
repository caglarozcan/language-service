using API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
	public class APIContext : DbContext
	{
		public APIContext(DbContextOptions<APIContext> option) 
			: base(option)
		{}

		public DbSet<Languages> Languages { get; set; }

		public DbSet<Translations> Translations { get; set; }
	}
}
