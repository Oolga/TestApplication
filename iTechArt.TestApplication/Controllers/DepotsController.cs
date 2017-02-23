using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.Web.ViewModels;
using System;
using System.Web.Mvc;

namespace iTechArt.TestApplication.Controllers
{
	public class DepotsController : Controller
    {
		[HttpGet]
		public ActionResult Depots()
		{
			try
			{
				IDepotsService service = new DepotsService();
				DepotsViewModel model = new DepotsViewModel();
				model.Depots=service.GetDepots();


				return View(model);
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Depots", "Depots"));
			}
		}

	}
}