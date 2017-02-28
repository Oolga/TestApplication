using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using iTechArt.TestApplication.DTO.Models;
using AutoMapper;

namespace iTechArt.TestApplication.Services.Domain
{
	public class DepotsService: IDepotsService
	{
		IDepotRepository depotRepository;
		IDrugUnitRepository drugUnitRepository;

		public DepotsService(IDepotRepository depotRepository, IDrugUnitRepository drugUnitRepository) {
			this.depotRepository = depotRepository;
			this.drugUnitRepository = drugUnitRepository;
		}
		public IEnumerable<DepotDTO> GetDepots()
		{
			var d = depotRepository.GetAll().Select(a => AutoMapper.Mapper.Map<Depot,DepotDTO>(a)).ToList();
			return d;
		}

		public IEnumerable<DrugUnitDTO> GetDrugUnits()
		{

			return drugUnitRepository.GetAll().Select(a=>Mapper.Map<DrugUnit,DrugUnitDTO>(a)).ToList();
		}

		public IEnumerable<DrugUnitDTO> GetSomeDrugUnits(int first, int count)
		{
			return drugUnitRepository.GetQueryableAll().Where(t=>t.DepotId.HasValue).OrderBy(t => t.DepotId).Skip(first).Take(count).ToList().Select(a => Mapper.Map<DrugUnit, DrugUnitDTO>(a)).ToList();
		}


		public int CetCountOfDrugUnits()
		{
			return drugUnitRepository.GetQueryableAll().Where(t => t.DepotId.HasValue).Count();
		}

	}
}
