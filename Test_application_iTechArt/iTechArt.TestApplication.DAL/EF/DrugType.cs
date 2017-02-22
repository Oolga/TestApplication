using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTechArt.TestApplication.DAL.EF
{
	public class DrugType: BaseEntity
	{
		public DrugType()
		{
			this.DrugUnits = new HashSet<DrugUnit>();
		}
		public string DrugTypeName { get; set; }
		public double Weight { get; set; }

		public virtual ICollection<DrugUnit> DrugUnits { get; set; }
	}
}
