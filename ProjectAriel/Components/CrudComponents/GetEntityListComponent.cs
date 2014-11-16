using ProjectAriel.Repositories;
using System.Collections.Generic;

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