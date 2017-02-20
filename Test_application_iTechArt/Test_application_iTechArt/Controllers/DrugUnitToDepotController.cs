using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_application_iTechArt.Controllers
{
    public class DrugUnitToDepotController : Controller
    {
		// GET: DrugUnitToDepot
		public ActionResult DrugUnitToDepot()
		{
			try
			{
				IDepotRepository depotRepository = new DepotRepository();
				IDrugUnitRepository drugUnitRepository = new DrugUnitRepository();

				ViewBag.depots = depotRepository.GetAll();
				ViewBag.drugUnits = drugUnitRepository.GetAll();
				return View();
			}
			catch (Exception ex)
			{
				return View("Home/Error", new HandleErrorInfo(ex, "DrugUnitToDepot", "DrugUnitToDepot"));
			}
		}

		public ActionResult UpdateDrugUnitToDepot(int DrugUnitId, int DepotId)
		{
			try
			{
				IDrugUnitRepository drugUnitRepository = new DrugUnitRepository();

				DrugUnit unit = drugUnitRepository.GetAll().Where(x => x.DrugUnitId == DrugUnitId).First();
				unit.DepotId = DepotId;
				drugUnitRepository.Update(unit);

				return Redirect("/Home/MessageWindow?message=Changes saved.");
			}
			catch (Exception ex)
			{
				return View("Home/Error", new HandleErrorInfo(ex, "DrugUnitToDepot", "UpdateDrugUnitToDepot"));
			}
		}

	}
}