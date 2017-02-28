using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTechArt.TestApplication.DTO.Models
{
	public class DrugUnitDTO
	{
		public int Id { get; set; }
		public Nullable<int> DepotId { get; set; }
		public Nullable<int> PickNumber { get; set; }
		public string DrugTypeName { get; set; }

	}
}
