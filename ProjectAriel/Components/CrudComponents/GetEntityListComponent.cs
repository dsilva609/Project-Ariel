using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Components.CrudComponents
{
	public class GetEntityListComponent
	{
		public List<T> Execute<T>(IRepository<T> repo) where T : class
		{
			return repo.GetAll();
		}
	}
}