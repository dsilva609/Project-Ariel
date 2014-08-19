using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAriel.Repositories
{
	public interface IRepository<T>
	{
		void Add(T entity);
		List<T> GetAll();
		T GetByID(int ID);
		void Edit(int id, T entity);
		void Delete(int ID);
	}
}
