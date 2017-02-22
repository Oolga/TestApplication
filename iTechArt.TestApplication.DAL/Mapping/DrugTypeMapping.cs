using iTechArt.TestApplication.DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
