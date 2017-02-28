using System.Collections.Generic;
using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL;
using System.Linq;
using iTechArt.TestApplication.Services.Interfaces;
using System;
using iTechArt.TestApplication.DTO.Models;
using AutoMapper;

namespace iTechArt.TestApplication.Services.Domain
{
	public class CalculateService : ICalculateService
	{
		IDepotRepository depotRepository;
		IDrugUnitRepository drugUnitRepository;
		IDrugTypeRepository drugTypeRepository;

		public CalculateService(IDepotRepository depotRepository, IDrugTypeRepository drugTypeRepository,IDrugUnitRepository drugUnitRepository) {
			this.depotRepository = depotRepository;
			this.drugTypeRepository = drugTypeRepository;
			this.drugUnitRepository = drugUnitRepository;
		}

		public IEnumerable<DepotDTO> GetDepots()
		{
			return depotRepository.GetAll().Select(a => AutoMapper.Mapper.Map<Depot, DepotDTO>(a)).ToList();
		}

		public IEnumerable<DrugTypeDTO> GetDrugTypes()
		{
			return drugTypeRepository.GetAll().Select(a => AutoMapper.Mapper.Map<DrugType, DrugTypeDTO>(a)).ToList();
		}

		public IEnumerable<DrugUnitDTO> SearchDrugUnits(int depotId, int[] numbers)
		{
			List<DrugUnit> units = new List<DrugUnit>();

			for (int i = 0; i < numbers.Count(); i++)
			{
				for (int j = 0; j < numbers.ElementAt(i); j++)
				{
					if (j < (drugUnitRepository.GetQueryableAll().Where(x => x.DepotId == depotId && x.DtugTypeId == (i + 1))).ToList<DrugUnit>().Count)
						units.Add((drugUnitRepository.GetQueryableAll().Where(x => x.DepotId == depotId && x.DtugTypeId == (i + 1))).ToList<DrugUnit>().OrderBy(x => x.PickNumber).ElementAt(j));
				}
			}
			return units.Select(a => Mapper.Map<DrugUnit, DrugUnitDTO>(a)).ToList();
		}

		public int GetCountOfDepots()
		{
			return drugTypeRepository.GetQueryableAll().Count();
		}

		public int GetCountOfDrugTypes()
		{
			return depotRepository.GetQueryableAll().Count();
		}
	}
}
