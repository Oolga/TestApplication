using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.Web.ViewModels;
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

				return View(model);
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Сalculate", "Сalculate"));
			}

		}
		[HttpGet]
		public ActionResult UnitsSearch(int depotId, List<int> numbers)
		{
			try
			{
				return PartialView(calculateService.SearchDrugUnits(depotId,numbers));
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "Сalculate", "UnitsSearch"));
			}
		}
	}
}