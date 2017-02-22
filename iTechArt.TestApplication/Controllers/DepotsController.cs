using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using System;
using System.Web.Mvc;

namespace iTechArt.TestApplication.Controllers
{
	public class DepotsController : Controller
    {
		// GET: Depots
		public ActionResult Depots()
		{
			try
			{
				IDepotsService service = new DepotsService();

				ViewBag.depots = service.GetDepots();
				ViewBag.drugUnits = service.GetDrugUnits();

				return View();
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Depots", "Depots"));
			}
		}

	}
}