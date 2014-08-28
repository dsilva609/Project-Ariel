using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Components.CardComponents
{
	public class GetCardByIDComponent
	{
		public Card Execute(IRepository<Card> repo, int? ID)
		{
			return repo.GetByID(ID);
		}
	}
}