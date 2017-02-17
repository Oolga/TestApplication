using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_application_iTechArt.DAL.Models;

namespace Test_application_iTechArt.DAL
{
    public class DepotRepository
    {
        Entities db = new Entities();
        public void Add(Depot depot) {
            db.Depot.Add(depot);
            db.SaveChanges();
        }

        public List<Depot> GetAll() {
            return db.Depot.ToList<Depot>();
        }

        public void Update(Depot depot)
        {
            db.Entry(depot).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

    }
}
