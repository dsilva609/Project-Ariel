using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Components.CrudComponents
{
	public class DeleteEntityComponent
	{
		public void Execute<T>(IRepository<T> repo, int ID) where T : class
		{
			repo.Delete(ID);
		}
	}
}