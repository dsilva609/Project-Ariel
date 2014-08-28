using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Components.CardComponents
{
	public class AddCardComponent
	{
		public void Execute(IRepository<Card> repo, Card card)
		{
			repo.Add(card);
		}
	}
}