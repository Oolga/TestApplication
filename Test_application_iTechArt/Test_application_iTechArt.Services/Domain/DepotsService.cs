using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_application_iTechArt.Services.Interfaces;

namespace Test_application_iTechArt.Services.Domain
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
