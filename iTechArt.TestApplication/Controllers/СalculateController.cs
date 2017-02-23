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
		[HttpGet]
		public ActionResult Сalculate()
		{
			try
			{
				ICalculateService service = new CalculateService();
				CalculateViewModel model = new CalculateViewModel();
				model.Depots = service.GetDepots();
				model.DrugTypes = service.GetDrugTypes();

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