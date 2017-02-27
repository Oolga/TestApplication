using iTechArt.TestApplication.DAL.EF;
using System.Collections.Generic;

namespace iTechArt.TestApplication.Services.Interfaces
{
	public interface ICalculateService
	{
		IEnumerable<Depot> GetDepots();
		IEnumerable<DrugType> GetDrugTypes();
		IEnumerable<DrugUnit> SearchDrugUnits(int depotId, int[] numbers);

		int GetCountOfDepots();
		int GetCountOfDrugTypes();

	}
}
