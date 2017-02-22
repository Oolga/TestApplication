using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.EF;
using System.Collections.Generic;
using System.Linq;

namespace iTechArt.TestApplication.DAL
{
	public class DrugTypeRepository: IDrugTypeRepository, IRepository<DrugType>
	{
        EFModel db = new EFModel();
        public void Add(DrugType drugType)
        {
            db.DrugTypes.Add(drugType);
            db.SaveChanges();
        }

        public IEnumerable<DrugType> GetAll()
        {
            return db.DrugTypes.ToList<DrugType>();
        }

        public void Update(DrugType drugType)
        {
            db.Entry(drugType).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
