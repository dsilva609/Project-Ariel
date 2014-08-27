using ProjectAriel.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjectAriel.DAL
{
	public class ProjectArielContext : DbContext
	{
		public DbSet<Player> Players { get; set; }
		public DbSet<Card> Cards { get; set; }

		public ProjectArielContext()
			: base("ProjectAriel")
		{
			this.Configuration.LazyLoadingEnabled = false;
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}