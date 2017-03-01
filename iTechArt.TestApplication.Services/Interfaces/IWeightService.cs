using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTechArt.TestApplication.Services.Interfaces
{
	public interface IWeightService
	{
		IEnumerable<DepotDTO> GetDepots();
		IEnumerable<DrugTypeDTO> GetDrugTypes();
		IEnumerable<DrugUnitDTO> GetDrugUnitsForDepot(int depotId, int drugTypeId);
		int GetCountOfDepots();
		int GetCountOfDrugTypes();
		int GetCountOfDrugUnis(int depotId, int drugTypeId);
	}
}
