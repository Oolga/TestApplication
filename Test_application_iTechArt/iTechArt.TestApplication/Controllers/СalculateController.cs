using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace iTechArt.TestApplication.Controllers
{
	public class СalculateController : Controller
    {
		// GET: Сalculate
		public ActionResult Сalculate()
		{
			try
			{
				ICalculateService service = new CalculateService();

				ViewBag.depots = service.GetDepots();
				ViewBag.drugTypes = service.GetDrugTypes();

				return View();
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Сalculate", "Сalculate"));
			}

		}
		public ActionResult UnitsSearch(int depotId, List<int> numbers)
		{

			ICalculateService service = new CalculateService();
			try
			{


				return PartialView(service.SearchDrugUnits(depotId,numbers));
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Сalculate", "UnitsSearch"));
			}
		}
	}
}