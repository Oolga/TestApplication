using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.Web.ViewModels;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace iTechArt.TestApplication.Controllers
{
	public class DepotsController : Controller
	{
		IDepotsService depotService;

		public DepotsController(IDepotsService service)
		{
			depotService = service;
		}

		[HttpGet]
		public ActionResult Depots()
		{
			try
			{
				DepotsViewModel model = new DepotsViewModel();
				model.CountDrugUnits = depotService.CetCountOfDrugUnits();
				model.Depots = depotService.GetDepots();
				model.DrugUnits = depotService.GetSomeDrugUnits(0, 10);
				model.RenderDrugUnits = model.DrugUnits.Count() > 0;
				model.RenderDepots = model.Depots.Count() > 0;

				return View(model);
			}
			catch (Exception ex)
			{
				return View("../Home/Error", new HandleErrorInfo(ex, "Depots", "Depots"));
			}
		}

		[HttpGet]
		public JsonResult DepotsContent(int first, int count)
		{
			DepotsViewModel model = new DepotsViewModel();
			
			model.CountDrugUnits = depotService.CetCountOfDrugUnits();
			model.Depots = depotService.GetDepots();
			model.DrugUnits = depotService.GetSomeDrugUnits(first, count);
			model.RenderDrugUnits = model.DrugUnits.Count() > 0;
			model.RenderDepots = model.Depots.Count() > 0;

			var data = JsonConvert.SerializeObject(model, Formatting.None, new JsonSerializerSettings
			{
				ReferenceLoopHandling = ReferenceLoopHandling.Ignore

			});

			return new JsonResult()
			{
				Data =data,
				JsonRequestBehavior = JsonRequestBehavior.AllowGet,
				MaxJsonLength = Int32.MaxValue
			};



		}
	}
}