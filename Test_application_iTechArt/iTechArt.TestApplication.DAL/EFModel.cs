namespace iTechArt.TestApplication.DAL
{
	using EF;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;
	using System.Data.Entity.ModelConfiguration;
	using System.Linq;
	using System.Reflection;

	public class EFModel : DbContext
	{
		// Your context has been configured to use a 'EFModel' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'iTechArt.TestApplication.DAL.EFModel' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'EFModel' 
		// connection string in the application configuration file.
		public EFModel()
			: base("name=EFModel1")
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
		   .Where(type => !String.IsNullOrEmpty(type.Namespace))
		   .Where(type => type.BaseType != null && type.BaseType.IsGenericType
				&& type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
			foreach (var type in typesToRegister)
			{
				dynamic configurationInstance = Activator.CreateInstance(type);
				modelBuilder.Configurations.Add(configurationInstance);
			}
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Depot> Depots { get; set; }
		public DbSet<DrugUnit> DrugUnits { get; set; }
		public DbSet<DrugType> DrugTypes { get; set; }
		public DbSet<Country> Countrys { get; set; }

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}