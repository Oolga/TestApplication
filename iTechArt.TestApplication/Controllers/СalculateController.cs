using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.Web.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace iTechArt.TestApplication.Controllers
{
	public class СalculateController : Controller
    {
		ICalculateService calculateService;
		public СalculateController(ICalculateService service) {
			calculateService = service;
		}
		[HttpGet]
		public ActionResult Сalculate()
		{
			try
			{
				CalculateViewModel model = new CalculateViewModel();
				model.Depots = calculateService.GetDepots();
				model.DrugTypes = calculateService.GetDrugTypes();
				model.RenderDepots = calculateService.GetCountOfDepots() > 0;
				model.RenderDrugTypes = calculateService.GetCountOfDrugTypes() > 0;

				return View(model);
			}
			catch (Exception ex)
			{
				return View("../Home/Error", new HandleErrorInfo(ex, "Сalculate", "Сalculate"));
			}

		}
		[HttpGet]
		public JsonResult UnitsSearch(int depotId, int[] numbers)
		{
			try
			{
				UnitsSearchViewModel model = new UnitsSearchViewModel();
				model.DrugUnits = calculateService.SearchDrugUnits(depotId,numbers);
				model.RenderDrugUnits = !model.DrugUnits.Equals(null);


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

			}
			catch (Exception ex)
			{
				return new JsonResult();//View("../Home/Error", new HandleErrorInfo(ex, "Сalculate", "UnitsSearch"));
			}
		}
	}
}