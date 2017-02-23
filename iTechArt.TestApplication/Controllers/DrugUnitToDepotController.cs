using iTechArt.TestApplication.Services.Domain;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArt.TestApplication.Web.ViewModels;
using System;
using System.Web.Mvc;

namespace iTechArt.TestApplication.Controllers
{
	public class DrugUnitToDepotController : Controller
    {

		[HttpGet]
		public ActionResult DrugUnitToDepot()
		{
			try
			{
				IDrugUnitToDepotService service = new DrugUnitToDepotService();
				DrugUnitToDepotViewModel model = new DrugUnitToDepotViewModel();
				model.Depots = service.GetDepots();
				model.DrugUnits = service.GetDrugUnits();

				return View(model);
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "DrugUnitToDepot", "DrugUnitToDepot"));
			}
		}
		[HttpPost]
		public ActionResult UpdateDrugUnitToDepot(int DrugUnitId, int DepotId)
		{
			try
			{
				IDrugUnitToDepotService service = new DrugUnitToDepotService();

				service.UpdateUnitByDepotId(DrugUnitId, DepotId);
				return View();
			}
			catch (Exception ex)
			{
				return View("/Home/Error", new HandleErrorInfo(ex, "DrugUnitToDepot", "UpdateDrugUnitToDepot"));
			}
		}

		[HttpGet]
		public ActionResult UpdateDrugUnitToDepot()
		{ 
			return Redirect("/Home/MessageWindow?message=Changes saved.");
		}

	}
}