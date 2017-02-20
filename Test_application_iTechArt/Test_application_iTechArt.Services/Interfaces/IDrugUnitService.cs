using iTechArt.TestApplication.DAL.Models;
using System.Collections.Generic;

namespace iTechArt.TestApplication.Services.Interfaces
{
	public interface IDrugUnitService
	{
		IEnumerable<DrugUnit> GetDrugUnitsForDepot(int depotId, int drugTypeId);
	}
}
