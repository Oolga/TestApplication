using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTechArt.TestApplication.DAL.EF
{
	public class Depot: BaseEntity
	{
		public Depot()
		{
			this.DrugUnits = new HashSet<DrugUnit>();
		}

		public string DepotName { get; set; }
		public int? CountryId { get; set; }

		public virtual ICollection<DrugUnit> DrugUnits { get; set; }
		public virtual Country Country { get; set; }
	}
}
