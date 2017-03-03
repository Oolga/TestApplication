using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DTO.Models;
using System.Collections.Generic;

namespace iTechArt.TestApplication.DAL.Interfaces
{
	public interface IDepotRepository: IBaseRepository<Depot>
    {
		IEnumerable<DrugUnitDTO> GetSomeDrugUnits(int first, int count);

	}
}
