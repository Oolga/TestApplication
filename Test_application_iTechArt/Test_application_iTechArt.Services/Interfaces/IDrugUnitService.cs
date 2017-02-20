using System.Collections.Generic;
using Test_application_iTechArt.DAL.Models;

namespace Test_application_iTechArt.Services.Interfaces
{
	public interface IDrugUnitService
	{
		IEnumerable<DrugUnit> GetDrugUnitsForDepot(int depotId, int drugTypeId);
	}
}
