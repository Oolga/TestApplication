using System;
using System.Web.Mvc;
using Test_application_iTechArt.Services.Domain;
using Test_application_iTechArt.Services.Interfaces;

namespace Test_application_iTechArt.Controllers
{
	public class WeightController : Controller
    {
		// GET: Weight
		public ActionResult Weight()
		{
			try
			{
				IWeightService service = new WeightService();

				ViewBag.drugTypes =service.GetDrugTypes();
				ViewBag.depots = service.GetDepots();
				return View();
			}
			catch (Exception ex)
			{
				return View("Home/Error", new HandleErrorInfo(ex, "Weight", "Weight"));
			}
		}
		public ActionResult ShowWeight(int depotId, int drugTypeId)
		{
			try
			{
				IWeightService service = new WeightService();
				var units = service.GetDrugUnitsForDepot(depotId, drugTypeId);

				return PartialView(units);
			}
			catch (Exception ex)
			{
				return View("Home/Error", new HandleErrorInfo(ex, "Weight", "ShowWeight"));
			}
		}

	}
}