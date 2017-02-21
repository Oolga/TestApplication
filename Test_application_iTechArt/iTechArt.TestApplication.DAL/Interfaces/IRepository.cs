using System.Collections.Generic;

namespace iTechArt.TestApplication.DAL.Interfaces
{
	public interface IRepository<T>
	{
		IEnumerable<T> GetAll();
		void Add(T item);
		void Update(T depot);
	}
}
