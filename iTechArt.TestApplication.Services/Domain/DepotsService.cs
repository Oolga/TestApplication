using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace iTechArt.TestApplication.Services.Domain
{
	public class DepotsService: IDepotsService
	{
		IDepotRepository depotRepository;
		IDrugUnitRepository drugUnitRepository;

		public DepotsService(IDepotRepository depotRepository, IDrugUnitRepository drugUnitRepository) {
			this.depotRepository = depotRepository;
			this.drugUnitRepository = drugUnitRepository;
		}
		public IEnumerable<Depot> GetDepots()
		{
			return depotRepository.GetAll();
		}

		public IEnumerable<DrugUnit> GetDrugUnits()
		{
			return drugUnitRepository.GetAll();
		}

		public IEnumerable<DrugUnit> GetSomeDrugUnits(int first, int count)
		{
			return drugUnitRepository.GetQueryableAll().Where(t=>t.DepotId.HasValue).OrderBy(t => t.DepotId).Skip(first).Take(count).ToList();
		}

	}
}
