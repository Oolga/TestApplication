using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.Web.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace iTechArt.TestApplication.Controllers
{
	public class DepotsController : Controller
	{
		IDepotsService depotService;

		public DepotsController(IDepotsService service)
		{
			depotService = service;
		}

		[HttpGet]
		public ActionResult Depots()
		{
			try
			{
				DepotsViewModel model = new DepotsViewModel();
				model.CountDrugUnits = depotService.CetCountOfDrugUnits();
				model.Depots = depotService.GetDepots();
				model.DrugUnits = depotService.GetSomeDrugUnits(0, 10);
				model.RenderDrugUnits = model.DrugUnits.Count() > 0;
				model.RenderDepots = model.Depots.Count() > 0;

				return View(model);
			}
			catch (Exception ex)
			{
				return View("../Home/Error", new HandleErrorInfo(ex, "Depots", "Depots"));
			}
		}
	}
}