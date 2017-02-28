using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DTO.Models;
using System.Collections.Generic;

namespace iTechArt.TestApplication.Services.Interfaces
{
	public interface IDepotsService
	{
		IEnumerable<DepotDTO> GetDepots();
		IEnumerable<DrugUnitDTO> GetDrugUnits();
		IEnumerable<DrugUnitDTO> GetSomeDrugUnits(int first, int count);
		int CetCountOfDrugUnits();
	}
}
