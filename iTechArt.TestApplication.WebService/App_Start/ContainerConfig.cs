using Autofac;
using Autofac.Integration.Mvc;
using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using System.Reflection;
using System.Web.Mvc;

namespace iTechArt.TestApplication.WebService.App_Start
{
	public class ContainerConfig
	{
		public static void RegisterContainer()
		{
			var builder = new Autofac.ContainerBuilder();
			builder.RegisterControllers(Assembly.GetExecutingAssembly());

			builder.RegisterType<DepotRepository>().As<IDepotRepository>().InstancePerRequest();
			builder.RegisterType<DrugUnitRepository>().As<IDrugUnitRepository>();
			builder.RegisterType<DrugTypeRepository>().As<IDrugTypeRepository>();

			builder.RegisterType<DepotsService>().As<IDepotsService>();
			builder.RegisterType<DrugUnitToDepotService>().As<IDrugUnitToDepotService>();
			builder.RegisterType<CalculateService>().As<ICalculateService>();
			builder.RegisterType<WeightService>().As<IWeightService>();

			var container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
		}
	}
}