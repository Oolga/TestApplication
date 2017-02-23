using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace iTechArt.TestApplication.Services.Domain
{
	public class WeightService:IWeightService
	{
		public IEnumerable<Depot> GetDepots()
		{
			IDepotRepository depotRepository = new DepotRepository();
			return depotRepository.GetAll();
		}

		public IEnumerable<DrugType> GetDrugTypes()
		{
			IDrugTypeRepository drugTypeRepository = new DrugTypeRepository();
			return drugTypeRepository.GetAll();
		}
		public IEnumerable<DrugUnit> GetDrugUnitsForDepot(int depotId, int drugTypeId)
		{
			IDrugUnitRepository drugUnitRepository = new DrugUnitRepository();

			List<DrugUnit> units = drugUnitRepository.GetQueryableAll().Where(x => x.DepotId == depotId && x.DtugTypeId == drugTypeId).ToList<DrugUnit>();
			units.ForEach(x => x.DrugType.Weight = Math.Round(x.DrugType.Weight / 2.2, 2));

			return units;
		}
	}
}
