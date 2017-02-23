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


				return View(model);
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Depots", "Depots"));
			}
		}

	}
}