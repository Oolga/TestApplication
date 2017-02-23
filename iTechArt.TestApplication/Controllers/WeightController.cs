using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.Web.ViewModels;
using System;
using System.Web.Mvc;

namespace Test_application_iTechArt.Controllers
{
	public class WeightController : Controller
    {
		[HttpGet]
		public ActionResult Weight()
		{
			try
			{
				IWeightService service = new WeightService();
				WeightViewModel model = new WeightViewModel();
				model.DrugTypes =service.GetDrugTypes();
				model.Depots = service.GetDepots();
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
				IWeightService service = new WeightService();
				var units = service.GetDrugUnitsForDepot(depotId, drugTypeId);

				return PartialView(units);
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Weight", "ShowWeight"));
			}
		}

	}
}