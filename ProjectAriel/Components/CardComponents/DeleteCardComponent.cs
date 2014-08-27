using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Components.CardComponents
{
	public class DeleteCardComponent
	{
		public void Execute(IRepository<Card> repo, int ID)
		{
			repo.Delete(ID);
		}
	}
}