using iTechArt.TestApplication.DAL.EF;
using System.Collections.Generic;

namespace iTechArt.TestApplication.Services.Interfaces
{
	public interface IDepotsService
	{
		IEnumerable<Depot> GetDepots();
		IEnumerable<DrugUnit> GetDrugUnits();
		IEnumerable<DrugUnit> GetSomeDrugUnits(int first, int count);
		int CetCount();
	}
}
