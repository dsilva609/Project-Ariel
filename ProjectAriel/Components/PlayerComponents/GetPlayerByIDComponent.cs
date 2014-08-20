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
		public Player Execute(IRepository<Player> repo, int ID)
		{//TODO do some null checking
			return repo.GetByID(ID);

		}
	}
}