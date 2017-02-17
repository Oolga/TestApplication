using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_application_iTechArt.DAL
{
    public class CountryRepository
    {
        Entities db = new Entities();
        public void Add(Country country)
        {
            db.Country.Add(country);
            db.SaveChanges();
        }

        public List<Country> GetAll()
        {
            return db.Country.ToList<Country>();
        }

        public void Update(Country country)
        {
            db.Entry(country).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

    }
}
