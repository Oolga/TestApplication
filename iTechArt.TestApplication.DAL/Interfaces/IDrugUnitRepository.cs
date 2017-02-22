using iTechArt.TestApplication.DAL.EF;
using System.Collections.Generic;

namespace iTechArt.TestApplication.DAL.Interfaces
{
    public interface IDrugUnitRepository
    {
		IEnumerable<DrugUnit> GetAll();
		void Update(DrugUnit depot);
		DrugUnit GetById(int id);
	}
}
