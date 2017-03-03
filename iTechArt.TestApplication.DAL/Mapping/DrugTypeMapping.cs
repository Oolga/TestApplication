using iTechArt.TestApplication.DAL.EF;
using System.Data.Entity.ModelConfiguration;

namespace iTechArt.TestApplication.DAL.Mapping
{
	class DrugTypeMapping: EntityTypeConfiguration<DrugType>
	{
		public DrugTypeMapping() {
			HasKey(t => t.Id);
			ToTable("DrugType");

			Property(t => t.Id).HasColumnName("DrugTypeId");
			Property(t => t.Weight).IsRequired();
			Property(t=>t.DrugTypeName).IsRequired(); 
		}
	}
}
