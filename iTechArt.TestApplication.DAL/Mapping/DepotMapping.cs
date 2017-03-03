using iTechArt.TestApplication.DAL.EF;
using System.Data.Entity.ModelConfiguration;

namespace iTechArt.TestApplication.DAL.Mapping
{
	public class DepotMapping: EntityTypeConfiguration<Depot>
	{
		public DepotMapping() {
			HasKey(t=>t.Id);
			ToTable("Depot");

			Property(t => t.Id).HasColumnName("DepotId");
			Property(t => t.DepotName).IsRequired();

			HasOptional(t => t.Country).WithMany(t => t.Depots).HasForeignKey(t => t.CountryId);
		}
	}
}
