using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace iTechArt.TestApplication.DAL.Repositories
{
	public abstract class BaseRepository<T> where T: BaseEntity
	{
		private readonly EFModel _context;
		private IDbSet<T> _entities;

		public BaseRepository()
		{
			this._context = new EFModel();
		}

		private IDbSet<T> Entities
		{
			get { return _entities ?? (_entities = _context.Set<T>()); }
		}

		#region IRepository Inteface Implementation

		public T GetById(int id)
		{
			return Entities.Find(id);
		}

		public IEnumerable<T> GetAll()
		{
			return Entities.ToList<T>();
		}

		public IQueryable<T> GetQueryableAll()
		{
			return Entities;
		}

		public void Add(T item)
		{
			Entities.Add(item);
			_context.SaveChanges();

		}

		public void Update(T depot)
		{
			_context.SaveChanges();
		}


		#endregion
	}
}
