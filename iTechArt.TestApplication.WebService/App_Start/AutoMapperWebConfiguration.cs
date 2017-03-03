using AutoMapper;
using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DTO.Models;

namespace iTechArt.TestApplication.WebService.App_Start
{
	public class AutoMapperWebConfiguration
	{
		public static void Configure()
		{
			Mapper.Initialize(cfg => {
				cfg.CreateMap<Depot, DepotDTO>().ForMember(a => a.CountryName, x => x.MapFrom(u => u.Country.CountryName));
				cfg.CreateMap<DrugUnit, DrugUnitDTO>().ForMember(a => a.DrugTypeName, x => x.MapFrom(u => u.DrugType.DrugTypeName))
				.ForMember(a => a.Weight, x => x.MapFrom(u => u.DrugType.Weight))
				.ForMember(a => a.DepotName, x => x.MapFrom(u => u.Depot.DepotName));
				cfg.CreateMap<DrugType, DrugTypeDTO>();
			});
		}
	}
}