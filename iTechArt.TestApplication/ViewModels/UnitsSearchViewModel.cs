using iTechArt.TestApplication.DAL.EF;
using iTechArt.TestApplication.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iTechArt.TestApplication.Web.ViewModels
{
	public class UnitsSearchViewModel
	{
		public IEnumerable<DrugUnitDTO> DrugUnits { get; set; }
		public bool RenderDrugUnits { get; set; }
	}
}