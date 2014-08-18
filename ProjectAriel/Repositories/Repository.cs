using ProjectAriel.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ProjectAriel.Repositories
{
	public class Repository<T> : IRepository<T> where T : class
	{
		//public ProjectArielContextWrapper Database { get; set; }

		//~Repository()
		//{
		//	Database.Dispose();
		//}

		private readonly DbContext _Context;
		private readonly DbSet<T> _DBSet;

		public Repository(DbContext context)
		{
			this._Context = context;
			this._DBSet = context.Set<T>();
		}

		public virtual void Add(T entity)
		{
			this._DBSet.Add(entity);
			this._Context.SaveChanges();
		}

		public virtual void Delete(T entity)
		{//TODO finish this
			var entry = this._Context.Entry(entity);
			//entry.State = System.Data.EntityState.Deleted;
		}

		public virtual void Update(T entity)
		{//TODO finish this
			var entry = this._Context.Entry(entity);
			this._DBSet.Attach(entity);
			//entry.State = System.Data.EntityState.Modified;
		}

		//public virtual T GetById(int ID)
		//{
		//	return _dbset.Find(ID);
		//}

		public virtual IEnumerable<T> All()
		{//TODO what does this do?
			return this._DBSet;
		}

		public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
		{//TODO should this be private?
			return this._DBSet.Where(predicate);
		}


		public List<T> GetAll()
		{
			return this._DBSet.ToList();
		}

		public T GetByID(int ID)
		{
			return this._DBSet.Find(ID);
		}

		public void Edit(T entity)
		{
			throw new NotImplementedException();
		}
	}
}