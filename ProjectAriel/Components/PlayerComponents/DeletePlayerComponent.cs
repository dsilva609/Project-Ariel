using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Components.PlayerComponents
{
	public class DeletePlayerComponent
	{
		private IRepository<Player> _repo;

		public DeletePlayerComponent(IRepository<Player> repo)
		{
			this._repo = repo;
		}

		public void Execute(int ID)
		{
			this._repo.Delete(ID);
		}
	}
}