using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTechArt.TestApplication.DAL.EF
{
	public class Country: BaseEntity
	{
		public Country()
		{
			this.Depots = new HashSet<Depot>();
		}
		public string CountryName { get; set; }

		public virtual ICollection<Depot> Depots { get; set; }
	}
}
