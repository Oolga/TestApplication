using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.EF;
using System.Collections.Generic;
using System.Linq;


namespace iTechArt.TestApplication.DAL
{
    public class DrugUnitRepository: IDrugUnitRepository, IRepository<DrugUnit>
	{
        EFModel db = new EFModel();
        public void Add(DrugUnit drugUnit)
        {
            db.DrugUnits.Add(drugUnit);
            db.SaveChanges();
        }

        public IEnumerable<DrugUnit> GetAll()
        {
            return db.DrugUnits.ToList<DrugUnit>();
        }

        public void Update(DrugUnit drugUnit)
        {
            db.Entry(drugUnit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
