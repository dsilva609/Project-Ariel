using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repositories
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<TContext> GetRepository<TContext>() where TContext: class;
		void SaveChanges();
	}
}
