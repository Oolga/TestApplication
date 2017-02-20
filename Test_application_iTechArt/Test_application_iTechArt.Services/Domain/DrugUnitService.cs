using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace iTechArtTestApplication.Services.Domain
{
	public class DrugUnitService: IDrugUnitService
	{
		public IEnumerable<DrugUnit> GetDrugUnitsForDepot(int depotId, int drugTypeId)
		{
			IDrugUnitRepository drugUnitRepository = new DrugUnitRepository();

			List<DrugUnit> units = drugUnitRepository.GetAll().Where(x => x.DepotId == depotId && x.DrugTypeId == drugTypeId).ToList<DrugUnit>();
			units.ForEach(x => x.DrugType.Weight = Math.Round(x.DrugType.Weight / 2.2, 2));

			return units;
		}
	}
}
