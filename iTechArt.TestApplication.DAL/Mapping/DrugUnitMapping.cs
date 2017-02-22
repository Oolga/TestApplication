using iTechArt.TestApplication.DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTechArt.TestApplication.DAL.Mapping
{
	class DrugUnitMapping: EntityTypeConfiguration<DrugUnit>
	{
		public DrugUnitMapping() {
			HasKey(t=>t.Id);
			ToTable("DrugUnit");

			Property(t => t.Id).HasColumnName("DrugUnitId");
			//Property(t => t.DtugTypeId).IsRequired();

			HasOptional(t => t.Depot).WithMany(t => t.DrugUnits).HasForeignKey(t=>t.DepotId);
			HasOptional(t => t.DrugType).WithMany(t => t.DrugUnits).HasForeignKey(t=>t.DtugTypeId);

		}
	}
}
