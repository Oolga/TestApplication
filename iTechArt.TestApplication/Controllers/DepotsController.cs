using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.Web.ViewModels;
using System;
using System.Web.Mvc;

namespace iTechArt.TestApplication.Controllers
{
	public class DepotsController : Controller
	{
		IDepotsService depotService;

		public DepotsController(IDepotsService service) {
			depotService = service;
		}

		[HttpGet]
		public ActionResult Depots()
		{
			try
			{
				DepotsViewModel model = new DepotsViewModel();
				model.Depots=depotService.GetDepots();
				model.DrugUnits = depotService.GetSomeDrugUnits(0, 10);

				return View(model);
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Depots", "Depots"));
			}
		}

		[HttpGet]
		public ActionResult DepotsContent(int first, int count) {
			DepotsViewModel model = new DepotsViewModel();
			model.DrugUnits = depotService.GetSomeDrugUnits(first, count);
			return PartialView();
		}

	}
}