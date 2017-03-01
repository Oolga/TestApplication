using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iTechArt.TestApplication.Web.ViewModels
{
	public class WeightViewModel
	{
		public IEnumerable<DepotDTO> Depots { get; set; }
		public IEnumerable<DrugTypeDTO> DrugTypes { get; set; }
		public bool RenderDrugTypes { get; set; }
		public bool RenderDepots { get; set; }
	}
}