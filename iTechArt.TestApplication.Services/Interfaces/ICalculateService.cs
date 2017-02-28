using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DTO.Models;
using System.Collections.Generic;

namespace iTechArt.TestApplication.Services.Interfaces
{
	public interface ICalculateService
	{
		IEnumerable<DepotDTO> GetDepots();
		IEnumerable<DrugTypeDTO> GetDrugTypes();
		IEnumerable<DrugUnitDTO> SearchDrugUnits(int depotId, int[] numbers);

		int GetCountOfDepots();
		int GetCountOfDrugTypes();

	}
}
