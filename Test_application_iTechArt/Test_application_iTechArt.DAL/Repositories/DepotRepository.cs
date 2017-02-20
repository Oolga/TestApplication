using System.Collections.Generic;
using System.Linq;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.Models;

namespace iTechArt.TestApplication.DAL
{
	public class DepotRepository : IDepotRepository
	{
		Entities db = new Entities();

		#region Methods
		public void Add(Depot depot)
		{
			db.Depot.Add(depot);
			db.SaveChanges();
		}

		public IEnumerable<Depot> GetAll()
		{
			return db.Depot.ToList<Depot>();
		}

		public void Update(Depot depot)
		{
			db.Entry(depot).State = System.Data.Entity.EntityState.Modified;
			db.SaveChanges();
		}

		#endregion

	}
}
