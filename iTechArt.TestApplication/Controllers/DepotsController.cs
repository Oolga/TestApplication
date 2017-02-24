using iTechArt.TestApplication.Services.Domain;
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

		public DepotsController(IDepotsService service) {
			depotService = service;
		}

		[HttpGet]
		public ActionResult Depots()
		{
			try
			{
				DepotsViewModel model = new DepotsViewModel();
				model.CountDrugUnits = depotService.CetCount();
				model.Depots = depotService.GetDepots();
				model.DrugUnits = depotService.GetSomeDrugUnits(0, 10);
				model.RenderItems = model.Depots.Count() > 0;

				return View(model);
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Depots", "Depots"));
			}
		}

		[HttpGet]
		public JsonResult DepotsContent(int first, int count) {

			DepotsViewModel model = new DepotsViewModel();
			model.CountDrugUnits = depotService.CetCount();
			model.Depots = depotService.GetDepots();
			model.DrugUnits = depotService.GetSomeDrugUnits(first, count);

			return new JsonResult()
			{
				Data = model,
				JsonRequestBehavior = JsonRequestBehavior.AllowGet
			};
		}

	}
}