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

		public Player GetByID(int ID)
		{//TODO needs null check
			return this._Repository.GetByID(ID);
		}

		public void Edit(int ID, Player player)
		{
			this._Repository.Edit(ID, player);
		}

		public void Delete(int ID)
		{
			this._Repository.Delete(ID);
		}
	}
}