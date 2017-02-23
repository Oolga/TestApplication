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
		IDepotRepository depotRepository;
		IDrugUnitRepository drugUnitRepository;
		IDrugTypeRepository drugTypeRepository;

		public WeightService(IDepotRepository depotRepository, IDrugTypeRepository drugTypeRepository, IDrugUnitRepository drugUnitRepository) {
			this.depotRepository = depotRepository;
			this.drugTypeRepository = drugTypeRepository;
			this.drugUnitRepository = drugUnitRepository;
		}
		public IEnumerable<Depot> GetDepots()
		{
			return depotRepository.GetAll();
		}

		public IEnumerable<DrugType> GetDrugTypes()
		{
			return drugTypeRepository.GetAll();
		}
		public IEnumerable<DrugUnit> GetDrugUnitsForDepot(int depotId, int drugTypeId)
		{
			List<DrugUnit> units = drugUnitRepository.GetQueryableAll().Where(x => x.DepotId == depotId && x.DtugTypeId == drugTypeId).ToList<DrugUnit>();
			units.ForEach(x => x.DrugType.Weight = Math.Round(x.DrugType.Weight / 2.2, 2));

			return units;
		}
	}
}
