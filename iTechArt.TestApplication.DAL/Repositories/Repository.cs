using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace iTechArt.TestApplication.DAL.Repositories
{
	public abstract class Repository<T>: IRepository<T> where T: BaseEntity
	{
		private readonly IDbContext _context;
		private IDbSet<T> _entities;

		public Repository(IDbContext context)
		{
			this._context = context;
		}

		protected virtual IDbSet<T> Entities
		{
			get { return _entities ?? (_entities = _context.Set<T>()); }
		}
		public IEnumerable<T> GetAll() {
			return Entities;
		}

		public void Add(T item)
		{
			Entities.Add(item);
			_context.SaveChanges();
		}

		public void Update(T depot)
		{
		
			//Entities.
			_context.SaveChanges();
		}
	}
}
