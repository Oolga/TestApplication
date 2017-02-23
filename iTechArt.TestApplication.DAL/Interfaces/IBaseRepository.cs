using System.Collections.Generic;
using System.Linq;

namespace iTechArt.TestApplication.DAL.Interfaces
{
	public interface IBaseRepository<T>
	{
		IEnumerable<T> GetAll();

		IQueryable<T> GetQueryableAll();
		void Add(T item);
		void Update(T depot);
		T GetById(int id);
	}
}
