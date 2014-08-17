using ProjectAriel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProjectAriel.DAL
{
	public class ProjectArielContext : DbContext
	{
		public DbSet<Player> Players { get; set; }

		public ProjectArielContext()
			: base("ProjectAriel")
		{

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}