using ProjectAriel.DAL;
using ProjectAriel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectAriel.Common
{
	public class ProjectArielContextWrapper
	{
		public ProjectArielContext Database { private get; set; }

		public void Dispose()
		{
			Database.Dispose();
		}

		public int SaveChanges()
		{
			return Database.SaveChanges();
		}

		public IDbSet<Player> Players()
		{
			return Database.Players;
		}
	}
}