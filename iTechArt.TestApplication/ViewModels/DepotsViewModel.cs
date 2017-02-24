using iTechArt.TestApplication.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iTechArt.TestApplication.Web.ViewModels
{
	public class DepotsViewModel
	{
		public int CountDrugUnits { get; set; }
		public IEnumerable<Depot> Depots { get; set; }
		public IEnumerable<DrugUnit> DrugUnits { get; set; }
		public bool RenderItems { get; set; }
	}
}