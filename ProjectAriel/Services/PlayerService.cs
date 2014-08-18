using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Services
{
	public class PlayerService
	{
		private IRepository<Player> _Repository;

		public PlayerService(IUnitOfWork uow)
		{
			this._Repository = uow.GetRepository<Player>();
		}

		public void Add(Player player)
		{
			this._Repository.Add(player);
		}

		public IEnumerable<Player> GetAll()
		{
			return this._Repository.GetAll();
		}
	}
}