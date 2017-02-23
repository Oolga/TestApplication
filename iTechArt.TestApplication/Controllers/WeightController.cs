using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.Web.ViewModels;
using System;
using System.Web.Mvc;

namespace Test_application_iTechArt.Controllers
{
	public class WeightController : Controller
    {
		IWeightService weightService;
		public WeightController(IWeightService service) {
			weightService = service;
		}
		[HttpGet]
		public ActionResult Weight()
		{
			try
			{
				WeightViewModel model = new WeightViewModel();
				model.DrugTypes = weightService.GetDrugTypes();
				model.Depots = weightService.GetDepots();
				return View(model);
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Weight", "Weight"));
			}
		}
		[HttpGet]
		public ActionResult ShowWeight(int depotId, int drugTypeId)
		{
			try
			{
				var units = weightService.GetDrugUnitsForDepot(depotId, drugTypeId);

				return PartialView(units);
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Weight", "ShowWeight"));
			}
		}

	}
}