using iTechArt.TestApplication.DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
