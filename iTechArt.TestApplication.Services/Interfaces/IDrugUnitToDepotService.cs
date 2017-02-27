using iTechArt.TestApplication.DAL.EF;
using System.Collections.Generic;

namespace iTechArt.TestApplication.Services.Interfaces
{
	public interface IDrugUnitToDepotService
	{
		IEnumerable<Depot> GetDepots();

		IEnumerable<DrugUnit> GetDrugUnits();

		void UpdateUnitByDepotId(int unitId, int depotId);

		int CetCountOfDrugUnits();
	}
}
