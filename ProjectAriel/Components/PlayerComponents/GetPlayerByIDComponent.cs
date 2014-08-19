using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Components.PlayerComponents
{
	public class GetPlayerByIDComponent
	{
		private IRepository<Player> _repo;
		
		public GetPlayerByIDComponent(IRepository<Player> repo)
		{
			this._repo = repo;
		}
		public Player Execute(int ID)
		{//TODO do some null checking
			return this._repo.GetByID(ID);

		}
	}
}