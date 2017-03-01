using System.Collections.Generic;
using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL;
using System.Linq;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.DTO.Models;

namespace iTechArt.TestApplication.Services.Domain
{
	public class DrugUnitToDepotService : IDrugUnitToDepotService
	{
		IDepotRepository depotRepository;
		IDrugUnitRepository drugUnitRepository;

		public DrugUnitToDepotService(IDepotRepository depotRepository, IDrugUnitRepository drugUnitRepository) {
			this.depotRepository = depotRepository;
			this.drugUnitRepository = drugUnitRepository;
		}
		public IEnumerable<DepotDTO> GetDepots()
		{
			return depotRepository.GetAll().Select(a => AutoMapper.Mapper.Map<Depot, DepotDTO>(a)).ToList();
		}

		public IEnumerable<DrugUnitDTO> GetDrugUnits()
		{
			return drugUnitRepository.GetAll().Select(a => AutoMapper.Mapper.Map<DrugUnit, DrugUnitDTO>(a)).ToList();
		}

		public void UpdateUnitByDepotId(int unitId, int depotId)
		{
			DrugUnit unit = drugUnitRepository.GetById(unitId);
			unit.DepotId = depotId;
			drugUnitRepository.Update(unit);
		}

		public IEnumerable<DrugUnitDTO> GetSomeDrugUnits(int first, int count)
		{
			return drugUnitRepository.GetQueryableAll().OrderBy(t => t.Id).Skip(first).Take(count).ToList().Select(a => AutoMapper.Mapper.Map<DrugUnit, DrugUnitDTO>(a)).ToList(); 
		}

		public int CetCountOfDrugUnits()
		{
			return drugUnitRepository.GetQueryableAll().Count();
		}

	}
}
