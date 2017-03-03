using iTechArt.TestApplication.DAL.EF;
using System.Data.Entity.ModelConfiguration;

namespace iTechArt.TestApplication.DAL.Mapping
{
	class CountryMapping: EntityTypeConfiguration<Country>
	{
		public CountryMapping()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasColumnName("CountryId");

			ToTable("Country");

			Property(t => t.CountryName).IsRequired();
		}
	}
}
