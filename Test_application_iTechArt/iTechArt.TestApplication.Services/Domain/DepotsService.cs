using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.Services.Interfaces;
using System.Collections.Generic;

namespace iTechArt.TestApplication.Services.Domain
{
	public class DepotsService: IDepotsService
	{
		public IEnumerable<Depot> GetDepots()
		{
			IDepotRepository depotRepository = new DepotRepository();
			return depotRepository.GetAll();
		}

		public IEnumerable<DrugUnit> GetDrugUnits()
		{
			IDrugUnitRepository drugUnitRepository = new DrugUnitRepository();
			return drugUnitRepository.GetAll();
		}

	}
}
