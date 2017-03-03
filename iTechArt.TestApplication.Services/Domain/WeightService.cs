using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using iTechArt.TestApplication.DTO.Models;

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
		public IEnumerable<DepotDTO> GetDepots()
		{
			return depotRepository.GetAll().Select(a => AutoMapper.Mapper.Map<Depot, DepotDTO>(a)).ToList();
		}

		public IEnumerable<DrugTypeDTO> GetDrugTypes()
		{
			return drugTypeRepository.GetAll().Select(a => AutoMapper.Mapper.Map<DrugType, DrugTypeDTO>(a)).ToList();
		}
		public IEnumerable<DrugUnitDTO> GetDrugUnitsForDepot(int depotId, int drugTypeId)
		{
			List<DrugUnitDTO> units = drugUnitRepository.GetQueryableAll().Where(x => x.DepotId == depotId && x.DtugTypeId == drugTypeId).ToList<DrugUnit>().Select(a => AutoMapper.Mapper.Map<DrugUnit, DrugUnitDTO>(a)).ToList(); 
			units.ForEach(x => x.Weight = Math.Round(x.Weight / 2.2, 2));

			return units;
		}

		public int GetCountOfDepots()
		{
			return depotRepository.GetQueryableAll().Count();
		}

		public int GetCountOfDrugTypes()
		{
			return drugTypeRepository.GetQueryableAll().Count();
		}

		public int GetCountOfDrugUnis(int depotId, int drugTypeId) {
			return drugUnitRepository.GetQueryableAll().Where(x => x.DepotId == depotId && x.DtugTypeId == drugTypeId).Count();
		}
	}
}
