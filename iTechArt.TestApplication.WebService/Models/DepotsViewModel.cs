using iTechArt.TestApplication.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iTechArt.TestApplication.WebService.Models
{
	public class DepotsViewModel
	{
		public int CountDrugUnits { get; set; }
		public IEnumerable<DepotDTO> Depots { get; set; }
		public IEnumerable<DrugUnitDTO> DrugUnits { get; set; }
		public bool RenderDepots { get; set; }
		public bool RenderDrugUnits { get; set; }
	}
}