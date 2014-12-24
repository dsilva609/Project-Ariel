using System;
using System.Data.Entity;
using BusinessLogic.DAL;
using UI.Models;
using BusinessLogic.Models;

namespace UI.Common
{
	public class ProjectArielContextWrapper : IDisposable
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

		public IDbSet<Card> Cards()
		{
			return Database.Cards;
		}
	}
}