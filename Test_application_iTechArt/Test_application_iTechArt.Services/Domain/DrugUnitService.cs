using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_application_iTechArt.DAL;
using Test_application_iTechArt.DAL.Interfaces;
using Test_application_iTechArt.DAL.Models;
using Test_application_iTechArt.Services.Interfaces;

namespace Test_application_iTechArt.Services.Domain
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
