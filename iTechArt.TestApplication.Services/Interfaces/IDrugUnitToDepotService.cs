using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DTO.Models;
using System.Collections.Generic;

namespace iTechArt.TestApplication.Services.Interfaces
{
	public interface IDrugUnitToDepotService
	{
		IEnumerable<DepotDTO> GetDepots();

		IEnumerable<DrugUnitDTO> GetDrugUnits();

		void UpdateUnitByDepotId(int unitId, int depotId);

		int CetCountOfDrugUnits();
	}
}
