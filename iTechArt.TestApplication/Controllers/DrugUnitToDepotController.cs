using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.Web.ViewModels;
using System;
using System.Web.Mvc;

namespace iTechArt.TestApplication.Controllers
{
	public class DrugUnitToDepotController : Controller
    {
		IDrugUnitToDepotService unitToDepotService;

		public DrugUnitToDepotController(IDrugUnitToDepotService service) {
			unitToDepotService = service;
		}

		[HttpGet]
		public ActionResult DrugUnitToDepot()
		{
			try
			{

				DrugUnitToDepotViewModel model = new DrugUnitToDepotViewModel();
				model.Depots = unitToDepotService.GetDepots();
				model.DrugUnits = unitToDepotService.GetDrugUnits();

				return View(model);
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "DrugUnitToDepot", "DrugUnitToDepot"));
			}
		}
		[HttpPost]
		public ActionResult UpdateDrugUnitToDepot(int drugUnitId, int depotId)
		{
			try
			{
				unitToDepotService.UpdateUnitByDepotId(drugUnitId, depotId);
				return Redirect("/Home/MessageWindow?message=Changes saved.");
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "DrugUnitToDepot", "UpdateDrugUnitToDepot"));
			}
		}

		


	}
}