using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Components.CrudComponents
{
	public class GetEntityByIDComponent
	{
		public T Execute<T>(IRepository<T> repo, int? ID) where T : class
		{
			return repo.GetByID(ID);
		}
	}
}