using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Components.CardComponents
{
	public class GetCardListComponent
	{
		public List<Card> Execute(IRepository<Card> repo)
		{
			return repo.GetAll();
		}
	}
}