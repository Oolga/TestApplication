using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTechArt.TestApplication.DAL.Interfaces
{
	public interface IRepository<T>
	{
		IEnumerable<T> GetAll();
		void Add(T item);
		void Update(T depot);
	}
}
