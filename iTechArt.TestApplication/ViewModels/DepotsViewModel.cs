﻿using iTechArt.TestApplication.DTO.Models;
using System.Collections.Generic;

namespace iTechArt.TestApplication.Web.ViewModels
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