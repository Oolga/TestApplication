using iTechArt.TestApplication.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace iTechArt.TestApplication.DAL.Interfaces
{
    public interface IDrugUnitRepository
    {
       IEnumerable<DrugUnit> GetAll();
       void Update(DrugUnit drugUnit);
    }
}
