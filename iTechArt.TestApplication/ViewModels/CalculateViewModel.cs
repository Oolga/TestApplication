using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DTO.Models;
using System.Collections.Generic;

namespace iTechArt.TestApplication.Web.ViewModels
{
	public class CalculateViewModel
	{
		public IEnumerable<DepotDTO> Depots { get; set; }
		public IEnumerable<DrugTypeDTO> DrugTypes { get; set; }
		public bool RenderDrugTypes { get; set; }
		public bool RenderDepots { get; set; }
	}
}