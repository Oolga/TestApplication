using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_application_iTechArt.DAL
{
    public class DrugUnitRepository
    {
        Entities db = new Entities();
        public void Add(DrugUnit drugUnit)
        {
            db.DrugUnit.Add(drugUnit);
            db.SaveChanges();
        }

        public List<DrugUnit> GetAll()
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
