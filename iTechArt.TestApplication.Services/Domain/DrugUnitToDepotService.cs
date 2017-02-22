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

		public void UpdateUnitByDepotId(int unitId, int depotId)
		{
			IDrugUnitRepository drugUnitRepository = new DrugUnitRepository();
			DrugUnit unit = drugUnitRepository.GetById(unitId);
			unit.DepotId = depotId;
			drugUnitRepository.Update(unit);
		}
	}
}
