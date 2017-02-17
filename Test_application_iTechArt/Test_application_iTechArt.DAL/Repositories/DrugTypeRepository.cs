using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_application_iTechArt.DAL.Models;

namespace Test_application_iTechArt.DAL
{
    public class DrugTypeRepository
    {
        Entities db = new Entities();
        public void Add(DrugType drugType)
        {
            db.DrugType.Add(drugType);
            db.SaveChanges();
        }

        public List<DrugType> GetAll()
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
