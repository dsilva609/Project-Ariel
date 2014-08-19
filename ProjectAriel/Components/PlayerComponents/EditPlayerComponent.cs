using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Components.PlayerComponents
{
	public class EditPlayerComponent
	{
		private IRepository<Player> _repo;

		public EditPlayerComponent(IRepository<Player> repo)
		{
			this._repo = repo;
		}

		public void Execute(Player player)
		{
			this._repo.Edit(player);
		}
	}
}