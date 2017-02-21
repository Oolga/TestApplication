using System.Collections.Generic;
using System.Linq;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.EF;


namespace iTechArt.TestApplication.DAL
{
	public class DepotRepository : IDepotRepository,IRepository<Depot>
	{
		EFModel db = new EFModel();

		#region Methods
		public void Add(Depot depot)
		{
			db.Depots.Add(depot);
			db.SaveChanges();
		}

		public IEnumerable<Depot> GetAll()
		{
			return db.Depots.ToList<Depot>();
		}

		public void Update(Depot depot)
		{
			db.Entry(depot).State = System.Data.Entity.EntityState.Modified;
			db.SaveChanges();
		}

		#endregion

	}
}
