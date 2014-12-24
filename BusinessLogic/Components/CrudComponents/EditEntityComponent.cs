using BusinessLogic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLogic.Components.CrudComponents
{
	public class EditEntityComponent
	{
		public void Execute<T>(IRepository<T> repo, T entity) where T : class
		{
			repo.Edit(entity);
		}
	}
}