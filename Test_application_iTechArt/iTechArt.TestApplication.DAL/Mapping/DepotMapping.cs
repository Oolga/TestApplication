using iTechArt.TestApplication.DAL.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTechArt.TestApplication.DAL.Mapping
{
	public class DepotMapping: EntityTypeConfiguration<Depot>
	{
		public DepotMapping() {
			HasKey(t=>t.Id);
			ToTable("Depot");

			Property(t => t.Id).HasColumnName("DepotId");
			Property(t => t.DepotName).IsRequired();
			//Property(t => t.CountryId).IsRequired();


			HasOptional(t => t.Country).WithMany(t => t.Depots).HasForeignKey(t => t.CountryId);
		}
	}
}
