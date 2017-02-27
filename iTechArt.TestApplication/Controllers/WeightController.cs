using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.Web.ViewModels;
using Newtonsoft.Json;
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
				model.RenderDepots = weightService.GetCountOfDepots() > 0;
				model.RenderDrugTypes = weightService.GetCountOfDrugTypes() > 0;

				return View(model);
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Weight", "Weight"));
			}
		}
		[HttpGet]
		public JsonResult ShowWeight(int depotId, int drugTypeId)
		{
			try
			{
				ShowWeightViewModel model = new ShowWeightViewModel();
				model.DrugUnits = weightService.GetDrugUnitsForDepot(depotId, drugTypeId);
				model.RenderDrugUnits = weightService.GetCountOfDrugUnis(depotId,drugTypeId)>0;

				var data = JsonConvert.SerializeObject(model, Formatting.None, new JsonSerializerSettings
				{
					ReferenceLoopHandling = ReferenceLoopHandling.Ignore

				});

				return new JsonResult()
				{
					Data = data,
					JsonRequestBehavior = JsonRequestBehavior.AllowGet,
					MaxJsonLength = Int32.MaxValue
				};



				//return PartialView(model);
			}
			catch (Exception ex)
			{
				return new JsonResult();//View("/Home/Error", new HandleErrorInfo(ex, "Weight", "ShowWeight"));
			}
		}

	}
}