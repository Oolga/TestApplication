using iTechArt.TestApplication.DAL.EF;
using System.Data.Entity.ModelConfiguration;

namespace iTechArt.TestApplication.DAL.Mapping
{
	class DrugUnitMapping: EntityTypeConfiguration<DrugUnit>
	{
		public DrugUnitMapping() {
			HasKey(t=>t.Id);
			ToTable("DrugUnit");

			Property(t => t.Id).HasColumnName("DrugUnitId");

			HasOptional(t => t.Depot).WithMany(t => t.DrugUnits).HasForeignKey(t=>t.DepotId);
			HasOptional(t => t.DrugType).WithMany(t => t.DrugUnits).HasForeignKey(t=>t.DtugTypeId);

		}
	}
}
