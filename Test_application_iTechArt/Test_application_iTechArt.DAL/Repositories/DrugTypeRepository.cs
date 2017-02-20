using iTechArt.TestApplication.DAL.Models;
using iTechArtTestApplication.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace iTechArt.TestApplication.DAL
{
	public class DrugTypeRepository: IDrugTypeRepository
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
