using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Test_application_iTechArt.Services.Domain;
using Test_application_iTechArt.Services.Interfaces;

namespace Test_application_iTechArt.Controllers
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
				return View("Home/Error", new HandleErrorInfo(ex, "Сalculate", "Сalculate"));
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
				return View("Home/Error", new HandleErrorInfo(ex, "Сalculate", "UnitsSearch"));
			}
		}
	}
}