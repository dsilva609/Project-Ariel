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
		public void Execute(IRepository<Player> repo, int ID)
		{
			repo.Delete(ID);
		}
	}
}