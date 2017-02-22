namespace iTechArt.TestApplication.DAL
{
	using EF;
	using Mapping;
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;
	using System.Data.Entity.ModelConfiguration;
	using System.Linq;
	using System.Reflection;

	public class EFModel : DbContext
	{
		public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
		{
			return base.Set<TEntity>();
		}
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


		#region Protected Methods

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//dynamically load all configuration

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

		#endregion


	}

}