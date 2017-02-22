using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTechArt.TestApplication.DAL.EF
{
	public class DrugUnit: BaseEntity
	{
		public Nullable<int> DepotId { get; set; }
		public int? DtugTypeId { get; set; }
		public Nullable<int> PickNumber { get; set; }

		public virtual Depot Depot { get; set; }
		public virtual DrugType DrugType { get; set; }
	}
}
