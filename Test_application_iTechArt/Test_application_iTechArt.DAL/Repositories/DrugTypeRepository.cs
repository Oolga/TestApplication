using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace iTechArt.TestApplication.DAL
{
	public class DrugTypeRepository: IDrugTypeRepository, IRepository<DrugType>
	{
        Entities db = new Entities();
        public void Add(DrugType drugType)
        {
            db.DrugType.Add(drugType);
            db.SaveChanges();
        }

        public IEnumerable<DrugType> GetAll()
        {
            return db.DrugType.ToList<DrugType>();
        }

        public void Update(DrugType drugType)
        {
            db.Entry(drugType).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
