using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.Models;
using System.Collections.Generic;
using System.Linq;


namespace iTechArt.TestApplication.DAL
{
    public class DrugUnitRepository: IDrugUnitRepository, IRepository<DrugUnit>
	{
        Entities db = new Entities();
        public void Add(DrugUnit drugUnit)
        {
            db.DrugUnit.Add(drugUnit);
            db.SaveChanges();
        }

        public IEnumerable<DrugUnit> GetAll()
        {
            return db.DrugUnit.ToList<DrugUnit>();
        }

        public void Update(DrugUnit drugUnit)
        {
            db.Entry(drugUnit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
