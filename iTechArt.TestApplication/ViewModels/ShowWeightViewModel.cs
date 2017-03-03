using iTechArt.TestApplication.DTO.Models;
using System.Collections.Generic;

namespace iTechArt.TestApplication.Web.ViewModels
{
	public class ShowWeightViewModel
	{
		public IEnumerable<DrugUnitDTO> DrugUnits { get; set; }
		public bool RenderDrugUnits { get; set; }
	}
}