using System.Collections.Generic;
using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL;
using System.Linq;
using iTechArt.TestApplication.Services.Interfaces;

namespace iTechArt.TestApplication.Services.Domain
{
	public class DrugUnitToDepotService : IDrugUnitToDepotService
	{
		IDepotRepository depotRepository;
		IDrugUnitRepository drugUnitRepository;

		public DrugUnitToDepotService(IDepotRepository depotRepository, IDrugUnitRepository drugUnitRepository) {
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

		public void UpdateUnitByDepotId(int unitId, int depotId)
		{
			DrugUnit unit = drugUnitRepository.GetById(unitId);
			unit.DepotId = depotId;
			drugUnitRepository.Update(unit);
		}

		public IEnumerable<DrugUnit> GetSomeDrugUnits(int first, int count)
		{
			return drugUnitRepository.GetQueryableAll().OrderBy(t => t.Id).Skip(first).Take(count).ToList();
		}

	}
}
