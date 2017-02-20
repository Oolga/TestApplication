﻿using System.Collections.Generic;
using iTechArt.TestApplication.DAL.Models;
using Test_application_iTechArt.Services.Interfaces;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL;
using System.Linq;

namespace Test_application_iTechArt.Services.Domain
{
	public class CalculateService : ICalculateService
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

		public IEnumerable<DrugUnit> SearchDrugUnits(int depotId, List<int> numbers)
		{
			List<DrugUnit> units = new List<DrugUnit>();

			IDrugUnitRepository drugUnitRepository = new DrugUnitRepository();

			for (int i = 0; i < numbers.Count(); i++)
			{
				for (int j = 0; j < numbers.ElementAt(i); j++)
				{
					if (j < (drugUnitRepository.GetAll().Where(x => x.DepotId == depotId && x.DrugTypeId == (i + 1))).ToList<DrugUnit>().Count)
						units.Add((drugUnitRepository.GetAll().Where(x => x.DepotId == depotId && x.DrugTypeId == (i + 1))).ToList<DrugUnit>().OrderBy(x => x.PickNumber).ElementAt(j));
				}
			}
			return units;
		}

	}
}
