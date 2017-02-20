using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_application_iTechArt.DAL.Interfaces;
using Test_application_iTechArt.DAL.Models;

namespace Test_application_iTechArt.DAL
{
    public class DrugUnitRepository: IDrugUnitRepository
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
