using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Components.PlayerComponents
{
	public class AddPlayerComponent
	{
		private IRepository<Player> _repo;

		public AddPlayerComponent(IRepository<Player> repo)
		{
			this._repo = repo;

		}

		public void Execute(Player player)
		{
			this._repo.Add(player);
		}
	}
}