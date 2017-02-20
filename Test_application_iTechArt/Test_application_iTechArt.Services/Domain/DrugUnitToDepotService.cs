using System;
using System.Collections.Generic;
using iTechArt.TestApplication.DAL.Models;
using Test_application_iTechArt.Services.Interfaces;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL;
using System.Linq;

namespace Test_application_iTechArt.Services.Domain
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
			DrugUnit unit = drugUnitRepository.GetAll().Where(x => x.DrugUnitId == unitId).First();
			unit.DepotId = depotId;
			drugUnitRepository.Update(unit);
		}
	}
}
